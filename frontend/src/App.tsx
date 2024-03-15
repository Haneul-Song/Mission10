import './App.css';
import BowlingLeagueList from './BowlingLeague/BowlingLeagueList';
import Header from './Header';

function App() {
  return (
    <div className="App">
      <Header title="List of Bowlers" />
      <BowlingLeagueList />
    </div>
  );
}

export default App;
