﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroFormatter;

namespace DEM.Net.Lib
{
	[ZeroFormattable]
	public class DEMDataSet
    {

		[Index(0)]
		public virtual string Name { get; set; }

		[Index(1)]
		public virtual string Description { get; set; }
		[Index(2)]
		public virtual string PublicUrl { get; set; }
		[Index(3)]
		public virtual int ResolutionMeters { get; set; }

		[Index(4)]
		public virtual DEMFileFormat FileFormat { get; set; }

		[Index(5)]
		/// <summary>
		/// GDAL Virtual 
		/// </summary>
		public virtual string VRTFileUrl { get; set; }

        public DEMDataSet()
        {
        }

        // Examples datasets

        public static DEMDataSet SRTM_GL3_srtm
        {
            get
            {
                return new DEMDataSet()
                {
                    Name = "SRTM_GL3",
                    Description = "Shuttle Radar Topography Mission (SRTM GL3) Global 90m",
                    PublicUrl = "http://opentopo.sdsc.edu/raster?opentopoID=OTSRTM.042013.4326.1",
                    VRTFileUrl = "https://cloud.sdsc.edu/v1/AUTH_opentopography/Raster/SRTM_GL3/SRTM_GL3_srtm.vrt",
                    FileFormat = DEMFileFormat.SRTM_HGT,
                    ResolutionMeters = 90
                };
            }
        }

        public static DEMDataSet AW3D30
        {
            get
            {
                return new DEMDataSet()
                {
                    Name = "AW3D30",
                    Description = "ALOS World 3D - 30m",
                    PublicUrl = "http://opentopo.sdsc.edu/raster?opentopoID=OTALOS.112016.4326.2",
                    VRTFileUrl = "https://cloud.sdsc.edu/v1/AUTH_opentopography/Raster/AW3D30/AW3D30_alos.vrt",
                    FileFormat = DEMFileFormat.GEOTIFF,
                    ResolutionMeters = 30
                };
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
