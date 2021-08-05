// Libs
import { Component } from "react";
import axios from "axios";
// import {Link} from 'react-router-dom';

// Services
// import {parseJwt} from '../../services/Auth';

// Styles
import '../../assets/css/login.css';


class Login extends Component {
    constructor(props){
        super(props);
        this.state = {
            email : '',
            senha : '',
            mensagem : '',
            isLoading : false
        }
    }

    render() {
        return(
            <>
                <div>
                    <p>Login</p>
                </div>
            </>
        )
    }

}

export default Login;