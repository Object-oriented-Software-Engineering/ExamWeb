import { Button, Container, Header, Menu, Segment } from "semantic-ui-react";
import { Link, NavLink } from "react-router-dom";

export default function NavBar(){

    return(
        <Menu fixed="top" inverted className="navBar">
           <Menu.Header className="navTitle">Exam Generator</Menu.Header>
        </Menu>
    )
}