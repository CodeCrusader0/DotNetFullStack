import UserService from "./UserService";
import {useEffect,useState} from "react";
// import { Link } from "react-router-dom";

const List=()=>{

    let[userArr,setUserArr]=useState([]);

    useEffect(()=>{
        UserService.getAllUsers().then((result)=>{
            setUserArr(result.data);
        }).catch(()=>{});
    });

    const deleteUser=(id)=>{
        UserService.deleteUser(id).then(()=>{
            console.log("Deleted");
        }).catch(()=>{});
    }

    const renderList=()=>{
        return userArr.map((user)=>{
            return <tr key={user.id}><td>{user.id}</td><td>{user.name}</td><td>{user.addr}</td>
            <td><button type="button" onClick={()=>{deleteUser(user.id)}}>Delete</button> </td>
            </tr>
        })
    }

    return(
        <div>
            {renderList()}
        </div>
    );
}
export default List;