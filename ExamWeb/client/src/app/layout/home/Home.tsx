import { Link, NavLink } from "react-router-dom";
import { Button, Container, Header, Segment ,Image} from "semantic-ui-react";

export default function HomePage(){
    return(
        <Segment inverted textAlign="center" vertical className="masthead">
            <Container>
                <Header as='h2' size="huge" inverted content='-_-'/>
                <Button as={Link} to='/login' inverted content='Sign in' size="huge"/>
                <Button as={Link} to='/register' positive content='Sign up' size="huge"/>
            </Container>
        </Segment>
    )
}