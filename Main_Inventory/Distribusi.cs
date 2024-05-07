using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Distribusi

{
	public Pendistribusian()
	{
		public string namaDistributor { get; set; }
		public string  namaAdmin{ get; set;}
	}
	//constructor dari method pendistribusian
	public Pendistribusian(string namaDistributor,string namaAdmin)
	{
		this.namaDistributor = namaDistributor;
		this.namaAdmin = namaAdmin;
	}
}
