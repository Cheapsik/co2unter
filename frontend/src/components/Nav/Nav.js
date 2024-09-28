import './Nav.scss';
import { useNavigate, useLocation } from 'react-router-dom';


const Nav = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const shouldDisplay = location.pathname !== '/';

  return (
    <>
      {shouldDisplay && <nav><button className="home-button" onClick={() => navigate('/')}>Strona główna</button></nav>}
    </>
  );
}

  export default Nav;