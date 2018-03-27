import React from 'react';

class Player extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            score: this.props.score
        }
    }

    incrementScore(event) {
        this.setState({
            score: this.state.score + 10
        })
    }

    decrementScore(event) {
        this.setState({
            score: this.state.score - 10
        })
    }
    render() {
        const styles = {
            player: {
                display: 'flex',
                padding: 10
            },
            name: {
                flex: '1'
            },
            playerScore: {
                width: 200
            },
            score: {
                padding: 20
            }
        }
        return (
            <div style={styles.player}>
                <div style={styles.name}>{this.props.name}</div>
                <div style={styles.playerScore}>
                    <div>
                        <button
                            onClick={this
                            .decrementScore
                            .bind(this)}
                            style={styles.button}>-</button>
                        <span style={styles.score}>{this.state.score}</span>
                        <button
                            onClick={this
                            .incrementScore
                            .bind(this)}
                            style={styles.button}>+</button>
                    </div>
                </div>
            </div>
        );
    }
}

export default Player;
