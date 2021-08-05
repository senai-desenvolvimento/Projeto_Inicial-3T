// Libs
import { Component } from "react";
import axios from "axios";
import {Link} from 'react-router-dom';

// Services
// import {parseJwt} from '../../services/Auth';

// Components
import MenuControle from '../../components/MenuControle';

// Styles
import '../../assets/css/reset.css';
import '../../assets/css/equipamentos.css';


class Equipamentos extends Component {
    constructor(props){
        super(props);
        this.state = {
            x : ''
        }
    }

    render() {
        return(
            <>
                <MenuControle />
            </>
        )
    }
}

export default Equipamentos;