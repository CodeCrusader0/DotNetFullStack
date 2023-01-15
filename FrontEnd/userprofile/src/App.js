import Header from './Components/Header';
import './App.css';
import List from './Components/List';
import {BrowserRouter as Router,Route,Switch} from "react-router-dom"; 

function App() {
  return (
    <div className="App">
     <Header></Header>
     <Router>
      <Switch>
        <Route path={"/"} component={List}></Route>
      </Switch>
     </Router>
    </div>
  );
}

export default App;
