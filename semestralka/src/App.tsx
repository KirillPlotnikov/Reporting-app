import React, { ChangeEvent, EventHandler, SyntheticEvent, FormEvent } from 'react';

interface IState{
  categories: Array<any>
  products: Array<any>
  selectedProduct?: number
  questionMessage?: string
  email?: string
  fileName: string
  file?: File
  errors?: Array<any>
}

interface IProps{}

class Main extends React.Component<IProps, IState>{
  constructor(props: IProps){
    super(props);
    this.state ={
      categories: [{id: 0, name: "Select category"}],
      products: [{id: 0, name: "Select product"}],
      questionMessage: undefined,
      email: undefined,
      fileName: "Add",
      file: undefined,
      errors: []

    }
    this.loadCategories = this.loadCategories.bind(this);
    this.loadProducts = this.loadProducts.bind(this);
    this.loadForm = this.loadForm.bind(this);
    this.AJAXSubmit= this.AJAXSubmit.bind(this);
    this.handleChangeText= this.handleChangeText.bind(this);
  }

  componentDidMount() {
    this.loadCategories();
  }

  public loadCategories = () => { 
    fetch('http://localhost:60994/api/Products')
    .then(function(response: Response){
      return response.json();
    }).then((myJson: any) => {
      this.setState((prevState)=>{
        return {categories: [prevState, ...myJson]}
      });
    });
  }

  public loadProducts = (event: any) => {
    if(event.target!.value)
    fetch('http://localhost:60994/api/Products/'+ event.target!.value)
    .then(function(response: Response){
      return response.json();
    }).then((myJson: any) => {
      this.setState((prevState)=>{
        return {products: [prevState, ...myJson]}
      });
    });
  }

public loadForm = (event: any) => {
  this.setState({selectedProduct: event.target!.value})
}

public handleChangeText = (event: any) => {
  this.setState({questionMessage: event.target.value});
}

public handleChangeEmail = (event: any) => {
  this.setState({email: event.target.value});
}

public AJAXSubmit = async (event: any) => {
  event.preventDefault();
  const formData: FormData = new FormData();
  const file: FileList | null = (document.getElementById('questionFile') as HTMLInputElement).files;
  formData.append('Text', this.state.questionMessage!);
  formData.append('Email', this.state.email!);
  formData.append('ProductId', this.state.selectedProduct!.toString());
  formData.append('File', file?.item(0) as Blob);
  window.console.log(formData);
  const response: Response = await fetch('http://localhost:60994/api/Questions', {
    method: 'POST',
    headers: {'Accept': 'application/json'},
    body: formData
  });

  if(response.ok){
    window.alert('Thanks for contacting us. We will answer as soon as possible.');
    const json = await response.json();
    this.setState({selectedProduct: undefined, products: [{id: 0, name: "Select product"}], questionMessage: undefined, email: undefined});
    (document.getElementById('questionFile') as HTMLInputElement).value = "";
    (document.getElementById('categories') as any).value = 0; 
    (document.getElementById('products') as any).value = 0; 
  } else{
    const errorData = await response.json();

  }
  
  
  
  
}

  public render() {
    return(
      <div className="parent">
        <form action="http://localhost:60994/api/Questions" method="post" encType="multipart/form-data" onSubmit={this.AJAXSubmit}>
          <div className={"form-group"}>
            <label htmlFor="categories">Select category:</label>
            <select className={"form-control"} id="categories" onChange={this.loadProducts}>
              {this.state.categories.map(x => 
                <option key={x.id} value={x.id} >{x.name}</option>)}
            </select>
          </div>
          <div className={"form-group"}>
            <label htmlFor="products">Select product:</label>
            <select id="products"  className={"form-control"} onChange={this.loadForm} disabled={this.state.products.length > 1 ? false : true}>
              {this.state.products.map(p => 
                <option value={p.id}>{p.name}</option>)}
            </select>
          </div>
            <input type="hidden" name="productId" value={this.state.selectedProduct}></input>  
            <div className={"form-group"}>
              <label htmlFor={"text"}>Message</label>
              <textarea placeholder="Tell us what's wrong" className={"form-control"} id="text" required maxLength={500} name="text" value={this.state.questionMessage === undefined ? "" : this.state.questionMessage} onChange={this.handleChangeText} disabled={this.state.selectedProduct !== undefined ? false : true}></textarea>
            </div>
            <div className={"form-group"}>
              <label htmlFor={"email"}>E-mail</label>
              <input name="email" className={"form-control"} id="email" required type="email" placeholder="Enter your e-mail" value={this.state.email === undefined ? "" : this.state.email} onChange={this.handleChangeEmail} disabled={this.state.selectedProduct !== undefined ? false : true}/>
            </div>
            <div className={"custom-file"}>
              <input type="file" className={"custom-file-input"} name="file" id="questionFile" disabled={this.state.selectedProduct !== undefined ? false : true}/>
              <label className={"custom-file-label"} htmlFor={"file"}>Attach file</label>
            </div>
            <button className={"btn btn-lg btn-block btn-primary"} disabled={this.state.selectedProduct !== undefined ? false : true} type="submit">Send</button>
        </form>
      </div> 
    )
  }
}

function App() {
  return (
    <Main />
  );
}

export default App;
