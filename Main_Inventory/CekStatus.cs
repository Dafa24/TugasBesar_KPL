using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Automata
{
    internal class TransaksiBarang
    {
        public enum StatusVerifikasi
        {
            BelumDiverifikasi,
            Menunggu,
            Terverifikasi,
            Ditolak
        }

        public enum EventVerifikasi
        {
            Submit,
            Setujui,
            Tolak
        }

        public class MesinStatusVerifikasi
        {
            private StatusVerifikasi _statusSaatIni;

            public MesinStatusVerifikasi()
            {
                // Saat inisialisasi, status verifikasi diatur ke BelumDiverifikasi
                _statusSaatIni = StatusVerifikasi.BelumDiverifikasi;
            }

            public StatusVerifikasi StatusSaatIni
            {
                get { return _statusSaatIni; }
            }

            public void ProsesEvent(EventVerifikasi eventVerifikasi)
            {
                switch (_statusSaatIni)
                {
                    case StatusVerifikasi.BelumDiverifikasi:
                        if (eventVerifikasi == EventVerifikasi.Submit)
                            _statusSaatIni = StatusVerifikasi.Menunggu;
                        break;
                    case StatusVerifikasi.Menunggu:
                        if (eventVerifikasi == EventVerifikasi.Setujui)
                            _statusSaatIni = StatusVerifikasi.Terverifikasi;
                        else if (eventVerifikasi == EventVerifikasi.Tolak)
                            _statusSaatIni = StatusVerifikasi.Ditolak;
                        break;
                    case StatusVerifikasi.Terverifikasi:
                        // Tidak ada transisi tambahan setelah berhasil diverifikasi
                        break;
                    case StatusVerifikasi.Ditolak:
                        // Tidak ada transisi tambahan setelah ditolak
                        break;
                }
            }
        }
    }
}