using API.Data.Entities;
using API.Data.Repositories.Interfaces;

namespace API.Data.Repositories;

public class DeviceRepository : IDeviceRepository
{
	private readonly DataContext _context;

	public DeviceRepository(DataContext context)
	{
		_context = context;
	}

	public List<Device> GetDevices() {
		return _context.Devices.ToList();
	}

	public void AddDevice(Device device) {
		_context.Devices.Add(device);
	}
	
	public void EditDevice(Device device) {
		_context.Devices.Update(device);
	}
	
	public Device GetDeviceById(int id) {
		return _context.Devices.Find(id);	
	}
	
	public void DeleteDevice(Device device) 
	{
		_context.Devices.Remove(device);
	}

	public bool Complete()
	{
		return _context.SaveChanges() > 0;
	}
}
