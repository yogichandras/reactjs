import React from 'react';

class AddPlayer extends React.Component {
    constructor(props) {
        super(props)
        this.state ={
            name : ""
        }
        this.onPlayerChange = this.onPlayerChange.bind(this)
        this.addPlayer = this.addPlayer.bind(this)
       
    }

    onPlayerChange(event){
        this.setState({
            name: event.target.value
        })
    }
    
addPlayer(event){
    this.props.onAdd(this.state.name)
    this.setState({
        name: ""
    })
}
    
    render() {
        return (
            <div>
                <input onChange={this.onPlayerChange} type="text" placeholder="Put Your Ex-Girlfriend" value={this.state.name}/>
                <button onClick={this.addPlayer}>AddPlayer</button>
            </div>
        );
    }
}

export default AddPlayer;