import React from 'react';
import ReactDOM from 'react-dom';
import registerServiceWorker from './registerServiceWorker';
import Leaderboard from './Leaderboard.js'


ReactDOM.render(<Leaderboard />, document.getElementById('root'));
registerServiceWorker();
