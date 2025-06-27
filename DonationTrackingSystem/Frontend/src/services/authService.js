import api from '../api/axios'

const authService = {
  login: (email, password) => {
    return api.post('/auth/login', { email, password })
  },
  
  register: (userData) => {
    return api.post('/auth/register', userData)
  },
  
  logout: () => {
    localStorage.removeItem('token')
  },
  
  getCurrentUser: () => {
    return api.get('/auth/me')
  }
}

export default authService