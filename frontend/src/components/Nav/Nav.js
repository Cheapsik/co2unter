import './Nav.scss';
import { useNavigate } from 'react-router-dom';


const Nav = () => {
  const navigate = useNavigate();

  return (
    <nav>
      <button onClick={() => navigate('/')}>Home</button>
    </nav>
  );
}

  export default Nav;