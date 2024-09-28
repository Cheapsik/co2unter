import './Nav.scss';
import { useNavigate } from 'react-router-dom';


const Nav = () => {
  const navigate = useNavigate();

  return (
    <nav>
      <button className="home-button" onClick={() => navigate('/')}>Strona główna</button>
    </nav>
  );
}

  export default Nav;