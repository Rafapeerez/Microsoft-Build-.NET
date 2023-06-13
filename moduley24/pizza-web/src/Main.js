import React, { useState, useEffect } from "react";
import styled from "styled-components";

const PizzaFrame = styled.div`
    border: solid 1px gray;
    padding: 10px;
    margin: 15px 10px;
    border-radius: 5px;
    box-shadow: 0 0 5px grey;
    font-family: Arial;
`;

const Input = styled.input`
    border: solid 1px black;
    padding: 5px;
    border-radius: 3px;
`;

const Title = styled(Input)`
    text-transform: uppercase;
`;

const Save = styled.button`
   width: 100px;
   margin: 10px;
   background: green;
   color: white;
   font-size: 16px;
   padding: 10px;
   border-radius: 5px;
`;

//Pizza Component: capable of rendering the Pizza object. It also listens to changes from input and runs the update() function, if either text field changes.
const Pizza = ({ pizza }) => {
    const [data, setData] = useState(pizza);
    const [dirty, setDirty] = useState(false);

    function update(value, fieldName, obj) {
        setData({ ...obj, [fieldName]: value });
        setDirty(true);
    }
    function onSave() {
        setDirty(false);
        // make REST call
    }

    return (
        <React.Fragment>
            <PizzaFrame>
                <h3>
                    <Title onChange={(evt) => update(evt.target.value, 'name', data)} value={data.name} />
                </h3>
                <div>
                    <Input onChange={(evt) => update(evt.target.value, 'description', data)} value={data.description} />
                </div>
                {dirty ?
                    <div><Save onClick={onSave}>Save</Save></div> : null
                }
            </PizzaFrame>
        </React.Fragment>
    )
}
//Dirty variable keeps track of whether a user has attempted to change the input.


//Main Component: renders the initial data, a list of pizzas.
const Main = () => {
    const [pizzas, setPizzas] = useState([]); //Create a state with a list pizzas and a method to change the content in pizzas called setPizzas().

    //call side effects
    useEffect(() => { 
        fetchData(); //triggers a call to API, which in turn fetches your data from the backend, and ends up calling setPizzas() to update React app.
    }, [])

    function fetchData() {
        fetch("/pizzas")
            .then(response => response.json())
            .then(data => setPizzas(data)) 
    }

    const data = pizzas.map(pizza => <Pizza pizza={pizza} />)

    return (<React.Fragment>
        {pizzas.length === 0 ?
            <div>No pizzas</div> :
            <div>{data}</div>
        }
   </React.Fragment>)
}

export default Main;