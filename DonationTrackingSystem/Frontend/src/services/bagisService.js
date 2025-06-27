import api from '../api/axios'

const bagisService = {
  getBagislar: (params) => {
    return api.get('/bagislar', { params })
  },
  
  getBagisById: (id) => {
    return api.get(`/bagislar/${id}`)
  },
  
  createBagis: (bagisData) => {
    return api.post('/bagislar', bagisData)
  },
  
  updateBagis: (id, bagisData) => {
    return api.put(`/bagislar/${id}`, bagisData)
  },
  
  deleteBagis: (id) => {
    return api.delete(`/bagislar/${id}`)
  }
}

export default bagisService