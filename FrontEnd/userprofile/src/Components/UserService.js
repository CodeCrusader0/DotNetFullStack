import axios from "axios";

class UserService{

    constructor(){
        this.baseurl="http://localhost:5110/api/Users/";
    }

    getAllUsers(){
        return axios.get(this.baseurl);
    }

    getUser(id){
        return axios.get(this.baseurl+id);
    }

    deleteUser(id){
        return axios.delete(this.baseurl+id);
    }
    
}

export default new UserService();