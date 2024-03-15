import logo from './skylogo.png';

function Header(props: any) {
  return (
    <header className="row navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" />
      </div>

      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <h4 className="text-white">
          Welcome, this website lists out the information about the bowlers who
          are on the <em>Marlines</em> or <em>Sharks</em> teams
        </h4>
      </div>
    </header>
  );
}

export default Header;
