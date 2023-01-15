import UserService from "./UserService";
import {useEffect,useState} from "react";
import { useHistory } from "react-router-dom";
// import { Link } from "react-router-dom";

const List=()=>{

    let[userArr,setUserArr]=useState([]);
    let[user,setUser]=useState({name:"",addr:""});

//    let history=useHistory();

    useEffect(()=>{
        UserService.getAllUsers().then((result)=>{
            setUserArr(result.data);
        }).catch(()=>{});
    },[]);

    const deleteUser=(id)=>{
        UserService.deleteUser(id).then(()=>{
            console.log("Deleted");
            // history.push("/");

        }).catch(()=>{});
    }

    const handleChange=(event)=>{
        let{name,value}=event.target;
        setUser({...user,[name]:value});
    }

    const addUser=()=>{
        UserService.insertUser(user).then((result)=>{
            console.log("Added");
        }).catch(()=>{});
    }

    const renderList=()=>{
        return userArr.map((user)=>{
            return <tr key={user.id}><td>{user.id}</td><td>{user.name}</td><td>{user.addr}</td>
            <td><button type="button" name="btn" id="delete" onClick={()=>{deleteUser(user.id)}}>Delete</button> </td>
            </tr>
        })
    }

    return(
        <div>
            {renderList()}
            
            <form>
                <input type="text" name="name" id="name"
                value={user.name}
                onChange={handleChange}></input>
                
                <input type="text" name="addr" id="addr"
                value={user.addr}
                onChange={handleChange}></input>
            <button type="button" name="btn" id="insert" onClick={addUser}></button>
            </form>
        </div>
    );
}
export default List;