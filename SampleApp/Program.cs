﻿using DEM.Net.Lib;
using DEM.Net.Lib;
using Microsoft.SqlServer.Types;
using SqlServerSpatial.Toolkit;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Net;
using System.IO.Compression;
using System.Xml;
using System.Diagnostics;
using System.Windows.Media;
using System.Configuration;
using DEM.Net.glTF;
using AssetGenerator.Runtime;
using AssetGenerator;

namespace SampleApp
{
    class Program
    {
        static string _DataDirectory;

        [STAThread]
        static void Main(string[] args)
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            _DataDirectory = ConfigurationManager.AppSettings["DataDir"];
            IGeoTiffService geoTiffService = new GeoTiffService(_DataDirectory);
            ElevationService elevationService = new ElevationService(geoTiffService);

            //geoTiffService.GenerateDirectoryMetadata(DEMDataSet.AW3D30, false, true);
            // geoTiffService.GenerateFileMetadata(@"C:\Users\xfischer\AppData\Roaming\DEM.Net\ETOPO1\ETOPO1_Ice_g_geotiff.tif", false, false);
            string wkt4Tiles = "POLYGON ((5.9735200000000006 43.979698, 6.021922 43.979698, 6.021922 44.002967, 5.9735200000000006 44.002967, 5.9735200000000006 43.979698))";
            //SpatialTrace_GeometryWithDEMGrid(elevationService, geoTiffService, wkt4Tiles, DEMDataSet.AW3D30);

            //GeoTiffTests(geoTiffService, @"C:\Repos\DEM.Net\Data\18953150_dhm.tif");

            //GeoTiffTests(geoTiffService, @"C:\Repos\DEM.Net\Data\18953150_dhm_expo.tif");
            //LineDEMBenchmark(elevationService, DEMDataSet.AW3D30, 512);

            //PointDEMTest(elevationService, DEMDataSet.AW3D30, 39.713092, -77.725708);
            //LineDEMTest(elevationService, DEMDataSet.AW3D30, WKT_PLATEAU_PUYRICARD, 100);

            //HeightMapTest(elevationService, DEMDataSet.AW3D30, wkt4Tiles);


            

            string WKT_AIX_LESMILLES = "POLYGON ((5.359268188476562 43.47285413777968, 5.49041748046875 43.47285413777968, 5.49041748046875 43.56024232423529, 5.359268188476562 43.56024232423529, 5.359268188476562 43.47285413777968))";
            string WKT_AIX_PUYRICARD = "POLYGON ((5.429993 43.537854, 5.459132 43.537854, 5.459132 43.58151, 5.429993 43.58151, 5.429993 43.537854))";
            string WKT_STE_VICTOIRE = "POLYGON ((5.361328125 43.440954591707445, 5.80352783203125 43.440954591707445, 5.80352783203125 43.700644071512464, 5.361328125 43.700644071512464, 5.361328125 43.440954591707445))";
            string WKT_SCL_PLOMO = "POLYGON ((-70.81924438476562 -33.55169563498065, -70.0653076171875 -33.55169563498065, -70.0653076171875 -33.059320463472105, -70.81924438476562 -33.059320463472105, -70.81924438476562 -33.55169563498065))";
            string WKT_MT_BLANC = "POLYGON ((6.772385 45.882318, 6.772385 45.772313, 6.956124 45.772313, 6.956124 45.882318, 6.772385 45.882318))";
            string WKT_TRAIL = "POLYGON ((2.620153 42.653948, 2.563506 42.653948, 2.563506 42.61318, 2.620153 42.61318, 2.620153 42.653948))";
            string WKT_LAPAZ = "POLYGON ((-67.922789 -16.390452, -68.293022 -16.384976, -68.297279 -16.69934, -67.932587 -16.69934, -67.922789 -16.390452))";
            string WKT_LAPAZ_DBG = "POLYGON ((-67.998969 -16.390233, -68.000813 -16.390262, -68.000836 -16.391898, -67.998996 -16.391889, -67.998969 -16.390233))";
            string WKT_BOGOTA = "POLYGON ((-74.454346 4.434044, -73.850098 4.434044, -73.850098 5.041699, -74.454346 5.041699, -74.454346 4.434044))";
            string WKT_VENTOUX = "POLYGON ((5.495911 44.32876, 4.818878 44.32876, 4.818878 43.909766, 5.495911 43.909766, 5.495911 44.32876))";
            string WKT_EIGER_LARGE = "POLYGON ((8.157349 46.674197, 7.821587 46.674197, 7.821587 46.441642, 8.157349 46.441642, 8.157349 46.674197))";
            string WKT_EIGER_SMALL = "POLYGON ((8.070711 46.604713, 7.969817 46.603966, 7.961006 46.538228, 8.063903 46.539715, 8.070711 46.604713))";
            string WKT_TOCOPILLA = "POLYGON ((-69.99115 -21.964002, -70.239247 -21.964002, -70.239247 -22.21792, -69.99115 -22.21792, -69.99115 -21.964002))";
            string WKT_VERDON = "POLYGON ((6.423912 43.829697, 6.239099 43.829697, 6.239099 43.713053, 6.423912 43.713053, 6.423912 43.829697))";
            string WKT_GAP = "POLYGON ((6.281433 44.674833, 5.929474 44.674833, 5.929474 44.437702, 6.281433 44.437702, 6.281433 44.674833))";
            string WKT_VALGO = "POLYGON ((6.373444 44.913277, 5.971403 44.913277, 5.971403 44.73893, 6.373444 44.73893, 6.373444 44.913277))";


            // TODO correct this
            //TestGpxElevation(elevationService, DEMDataSet.AW3D30, @"..\..\..\Data\GPX\Bouleternere-Denivele_de_Noel_2017.gpx");
           // TestGpxMesh(elevationService, DEMDataSet.AW3D30, @"..\..\..\Data\GPX\Bouleternere-Denivele_de_Noel_2017.gpx", "Bouleternere");
            TestCombinedGpxMesh(elevationService, DEMDataSet.AW3D30, @"..\..\..\Data\GPX\Bouleternere-Denivele_de_Noel_2017.gpx", WKT_TRAIL, "Bouleternere");


            ExportGLBTest(elevationService, DEMDataSet.AW3D30, WKT_GAP,"Gap");
            MeshDecimationTest(elevationService, DEMDataSet.AW3D30, WKT_GAP, "Gap",0.5f) ;

            ExportGLBTest(elevationService, DEMDataSet.AW3D30, WKT_VALGO, "Valgo");
            MeshDecimationTest(elevationService, DEMDataSet.AW3D30, WKT_VALGO, "Valgo", 0.5f); ;


            //mrpoup : welcome !!

            //GeoTiffBenchmark();

            //Test_GetMetadataFromVRT(elevationService, DEMDataSet.AW3D30);

            //elevationService.DownloadMissingFiles(DEMDataSet.AW3D30, GetBoundingBox(WKT_AIX_BAYONNE_EST_OUEST));
            ////elevationService.DownloadMissingFiles(DEMDataSet.SRTM_GL3_srtm, GetBoundingBox(WKT_GRAND_TRAJET_MARSEILLE_ALPES_MULTIPLE_TILES));

            ////GenerateDownloadReports(geoTiffService);

            //geoTiffService.GenerateDirectoryMetadata(DEMDataSet.AW3D30, false, false);

            //Spatial trace of line +segments + interpolated point + dem grid
            //SpatialTrace_GeometryWithDEMGrid(elevationService, geoTiffService, WKT_TEST, DEMDataSet.AW3D30);

            Console.Write("Press any key to exit...");
            Console.ReadLine();

        }

        private static void TestGpxElevation(ElevationService elevationService, DEMDataSet dataSet, string gpxFile)
        {
            var segments =  GpxImport.ReadGPX_Segments(gpxFile);

            SpatialTrace.Enable();
            SpatialTrace.Clear();

            foreach (var line in segments)
            {
                List<GeoPoint> inputLine = line.ToList();



                var lineOut = elevationService.GetLineGeometryElevation(inputLine, dataSet);

                GeometryService.ComputeMetrics(inputLine);
                GeometryService.ComputeMetrics(lineOut);

                // Compare
                SpatialTraceLine(inputLine, "Input");

                // Compare
                SpatialTraceLine(lineOut.ToList(), "Output");

            }

            SpatialTrace.ShowDialog();
        }

        private static void TestGpxMesh(ElevationService elevationService, DEMDataSet dataSet, string gpxFile, string name)
        {
            var segments = GpxImport.ReadGPX_Segments(gpxFile);


            var points = segments.SelectMany(pt => pt);
            points = points.CenterOnOrigin(0.00002f);


            glTFService glTF = new glTFService();
            MeshPrimitive meshPrimitive = glTF.GenerateLine(points,new System.Numerics.Vector4(1,0,0,0),1f);
            
            Console.Write("GenerateModel...");
            Model model = glTF.GenerateModel(meshPrimitive, name);
            glTF.Export(model, @"C:\Repos\DEM.Net\Data\glTF", $"{name} line", false, true);
        }

        private static void TestCombinedGpxMesh(ElevationService elevationService, DEMDataSet dataSet, string gpxFile, string wkt, string name)
        {
            glTFService glTF = new glTFService();
            List<MeshPrimitive> meshes = new List<MeshPrimitive>();

            

            // MESH 3D terrain
            SqlGeometry geom = GeometryService.ParseWKTAsGeometry(wkt);
            var bbox = geom.GetBoundingBox();

            Console.Write("Height map...");
            HeightMap hMap = elevationService.GetHeightMap(bbox, dataSet);

            //hMap = hMap.ReprojectTo(4326, 2154);
            hMap = hMap.CenterOnOrigin(0.00002f);

            Console.Write("GenerateTriangleMesh...");
            MeshPrimitive triangleMesh = glTF.GenerateTriangleMesh(hMap);
            meshes.Add(triangleMesh);

            /// Line strip from GPX
            var segments = GpxImport.ReadGPX_Segments(gpxFile);

            var points = segments.SelectMany(pt => pt);
            points = points.CenterOnOrigin(hMap.BoundingBox, 0.00002f);

            MeshPrimitive meshPrimitive = glTF.GenerateLine(points, new System.Numerics.Vector4(1, 0, 0, 0), 0);
            meshes.Add(meshPrimitive);

            // model export
            Console.Write("GenerateModel...");
            Model model = glTF.GenerateModel(meshes, name);
            glTF.Export(model, @"C:\Repos\DEM.Net\Data\glTF", $"{name} combined", false, true);
        }


        private static void MeshDecimationTest(ElevationService elevationService, DEMDataSet dataSet, string wkt, string name, float quality = 0.5f)
        {
            SqlGeometry geom = GeometryService.ParseWKTAsGeometry(wkt);
            var bbox = geom.GetBoundingBox();

            Console.Write("Height map...");
            HeightMap hMap = elevationService.GetHeightMap(bbox, dataSet);

            //hMap = hMap.ReprojectTo(4326, 2154);
            hMap = hMap.CenterOnOrigin(0.00002f);

            Console.Write("GenerateTriangleMesh...");
            glTFService glTF = new glTFService();
            MeshPrimitive meshPrimitive = glTF.GenerateTriangleMesh(hMap);


            //Console.Write($"Decimate {quality * 100}...");
            //meshPrimitive = MeshDecimationWrapper.Decimate(meshPrimitive, quality);


            Console.Write("GenerateModel...");
            Model model = glTF.GenerateModel(meshPrimitive, name);
            glTF.Export(model, @"C:\Repos\DEM.Net\Data\glTF", $"{name} decimated {quality * 100}", false, true);
            ////HeightMapExport.Export(hMap_L93, "Aix Puyricard");
        }

        private static void ExportGLBTest(ElevationService elevationService, DEMDataSet dataSet, string wkt, string name)
        {
            SqlGeometry geom = GeometryService.ParseWKTAsGeometry(wkt);
            var bbox = geom.GetBoundingBox();

            HeightMap hMap = elevationService.GetHeightMap(bbox, dataSet);

            //hMap = hMap.ReprojectTo(4326, 2154);
            hMap = hMap.CenterOnOrigin(0.00002f);

            glTFService glTF = new glTFService();
            MeshPrimitive meshPrimitive = glTF.GenerateTriangleMesh(hMap);
            Model model = glTF.GenerateModel(meshPrimitive, name);
            glTF.Export(model, @"C:\Repos\DEM.Net\Data\glTF", name, false, true);
            //HeightMapExport.Export(hMap_L93, "Aix Puyricard");
        }

        private static void HeightMapTest(ElevationService elevationService, DEMDataSet dataSet, string wkt)
        {
            SqlGeometry geom = GeometryService.ParseWKTAsGeometry(wkt);
            var bbox = geom.GetBoundingBox();

            HeightMap hMap = elevationService.GetHeightMap(bbox, dataSet);

            HeightMap hMap_L93 = hMap.ReprojectTo(4326, 2154);
            //HeightMapExport.Export(hMap_L93, "Aix Puyricard");

        }

        private static void GeoTiffTests(IGeoTiffService geoTiffService, string tiffPath)
        {

            DEM.Net.Lib.BoundingBox bbox = new DEM.Net.Lib.BoundingBox(1897950, 1898106, 3150520, 3150700);

            HeightMap hmap = null;
            FileMetadata metaData = geoTiffService.ParseMetadata(tiffPath);
            using (IGeoTiff geoTiff = geoTiffService.OpenFile(tiffPath))
            {
                hmap = geoTiff.ParseGeoDataInBBox(bbox, metaData, 0);
            }
            //hmap = hmap.CenterOnOrigin(0.1f);
            glTFService glTF = new glTFService();
            MeshPrimitive meshPrimitive = glTF.GenerateTriangleMesh(hmap);
            Model model = glTF.GenerateModel(meshPrimitive, "FBA");
            glTF.Export(model, @"C:\Repos\DEM.Net\Data\glTF_FBA", "FBA DEM");

        }

        private static void GeoTiffBenchmark()
        {
            DEMDataSet dataSet = DEMDataSet.AW3D30;
            ElevationService elevationServiceLibTiff = new ElevationService(new GeoTiffService(_DataDirectory));

            string wkt = WKT_BREST_NICE;
            elevationServiceLibTiff.DownloadMissingFiles(dataSet, GetBoundingBox(wkt));

            const int NUM_ITERATIONS = 10;

            Stopwatch swCoreTiff = new Stopwatch();
            Stopwatch swGeoTiff = new Stopwatch();
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < NUM_ITERATIONS; i++)
                {


                    swGeoTiff.Start();
                    var lineElevationData = elevationServiceLibTiff.GetLineGeometryElevation(wkt, dataSet, InterpolationMode.Hyperbolic);
                    swGeoTiff.Stop();
                }
            }


            long geoTiffMs = swGeoTiff.ElapsedMilliseconds;

            long codeTiffMs = swCoreTiff.ElapsedMilliseconds;

            Console.WriteLine($"GeoTiff : {geoTiffMs} ms, Native : {codeTiffMs}");
        }

        private static void Test_GetMetadataFromVRT(ElevationService elevationService, DEMDataSet dataSet)
        {
            GDALVRTFileService gdalService = new GDALVRTFileService(elevationService.GetDEMLocalPath(dataSet), dataSet);

            gdalService.Setup(false);

            GDALSource source = gdalService.Sources().FirstOrDefault(s => s.SourceFileName.EndsWith("N043E006_AVE_DSM.tif"));



        }


        static void LineDEMBenchmark(ElevationService elevationService, DEMDataSet dataSet, int numSamples)
        {

            Dictionary<string, string> dicWktByName = new Dictionary<string, string>();
            //dicWktByName.Add(nameof(WKT_EXAMPLE_GOOGLE), WKT_EXAMPLE_GOOGLE);

            // Before GeoTiff window optim : 90s
            // After GeoTiff optim : 77s / release : 60s;


            dicWktByName.Add(nameof(WKT_BREST_NICE), WKT_BREST_NICE);
            dicWktByName.Add(nameof(WKT_HORIZONTAL_DEM_EDGE), WKT_HORIZONTAL_DEM_EDGE);
            dicWktByName.Add(nameof(WKT_VERTICAL_DEM_EDGE), WKT_VERTICAL_DEM_EDGE);
            dicWktByName.Add(nameof(WKT_MONACO), WKT_MONACO);
            dicWktByName.Add(nameof(WKT_TEST), WKT_TEST);
            dicWktByName.Add(nameof(WKT_NO_DEM), WKT_NO_DEM);
            dicWktByName.Add(nameof(WKT_ZERO), WKT_ZERO);
            dicWktByName.Add(nameof(WKT_NEG100), WKT_NEG100);
            dicWktByName.Add(nameof(WKT_BREST_SPAIN_OCEAN), WKT_BREST_SPAIN_OCEAN);
            dicWktByName.Add(nameof(WKT_EXAMPLE_GOOGLE), WKT_EXAMPLE_GOOGLE);
            dicWktByName.Add(nameof(WKT_PARIS_AIX), WKT_PARIS_AIX);
            dicWktByName.Add(nameof(WKT_PETITE_BOUCLE), WKT_PETITE_BOUCLE);
            dicWktByName.Add(nameof(WKT_GRAND_TRAJET), WKT_GRAND_TRAJET);
            dicWktByName.Add(nameof(WKT_GRAND_TRAJET_MARSEILLE_ALPES_MULTIPLE_TILES), WKT_GRAND_TRAJET_MARSEILLE_ALPES_MULTIPLE_TILES);
            dicWktByName.Add(nameof(WKT_BAYONNE_AIX_OUEST_EST), WKT_BAYONNE_AIX_OUEST_EST);
            dicWktByName.Add(nameof(WKT_AIX_BAYONNE_EST_OUEST), WKT_AIX_BAYONNE_EST_OUEST);
            dicWktByName.Add(nameof(WKT_BAYONNE_NICE_DIRECT), WKT_BAYONNE_NICE_DIRECT);
            dicWktByName.Add(nameof(WKT_DEM_INTERPOLATION_BUG), WKT_DEM_INTERPOLATION_BUG);

            Stopwatch sw = Stopwatch.StartNew();

            InterpolationMode[] modes = { InterpolationMode.Bilinear, InterpolationMode.Hyperbolic };
            for (int i = 0; i < 5; i++)
            {
                foreach (var wkt in dicWktByName)
                {
                    elevationService.DownloadMissingFiles(dataSet, GetBoundingBox(wkt.Value));

                    foreach (InterpolationMode mode in modes)
                    {
                        var lineElevationData = elevationService.GetLineGeometryElevation(wkt.Value, dataSet, mode);
                        ElevationMetrics metrics = GeometryService.ComputeMetrics(lineElevationData);
                        //var sampledLineElevationData = ReduceList(lineElevationData, numSamples).ToList();
                        //File.WriteAllText($"ElevationData_{wkt.Key}_{mode}.txt", elevationService.ExportElevationTable(lineElevationData));
                        //File.WriteAllText($"ElevationData_{wkt.Key}_{mode}_{numSamples}samples.txt", elevationService.ExportElevationTable(sampledLineElevationData));
                    }
                }
            }

            sw.Stop();
            Console.WriteLine($"LineDEMTests performed in {sw.Elapsed:g}.");
        }

        static void PointDEMTest(ElevationService elevationService, DEMDataSet dataSet, double lat, double lon)
        {

            elevationService.DownloadMissingFiles(dataSet, lat, lon);

            var geoPoint_Bilinear = elevationService.GetPointElevation(lat, lon, dataSet, InterpolationMode.Bilinear);
            Console.WriteLine($"Elevation with Bilinear model : {geoPoint_Bilinear.Elevation}");

            var geoPoint_Hyperbolic = elevationService.GetPointElevation(lat, lon, dataSet, InterpolationMode.Hyperbolic);
            Console.WriteLine($"Elevation with Hyperbolic model : {geoPoint_Hyperbolic.Elevation}");



        }
        static void LineDEMTest(ElevationService elevationService, DEMDataSet dataSet, string wkt, int numSamples)
        {

            Stopwatch sw = Stopwatch.StartNew();

            elevationService.DownloadMissingFiles(dataSet, GetBoundingBox(wkt));

            var lineElevationData = elevationService.GetLineGeometryElevation(wkt, dataSet, InterpolationMode.Bilinear);
            ElevationMetrics metrics = GeometryService.ComputeMetrics(lineElevationData);
            var lineElevationData_Reduced = DouglasPeucker.DouglasPeuckerReduction(lineElevationData, (metrics.MaxElevation - metrics.MinElevation) / numSamples);

            sw.Stop();
            Console.WriteLine($"LineDEMTest performed in {sw.Elapsed:g}.");

            SpatialTrace.Enable();
            SpatialTrace.Clear();
            SpatialTraceLine(lineElevationData, $"Full resolution line ({lineElevationData.Count} points)");


            SpatialTraceLine(lineElevationData_Reduced, $"Reduced line ({lineElevationData_Reduced.Count} points)");

            SpatialTrace.ShowDialog();


        }

        private static void SpatialTraceLine(List<GeoPoint> lineElevationData, string message)
        {

            const int DEFAULT_HEIGHT = 300;
            // Say that 1 sample is one pixel and a graph is usually 300px tall
            // So 300px = 300 samples = max height (H)
            // So for numSamples, (H * numSamples / 300) = height of 1px


            double minH = lineElevationData.Min(p => p.Elevation.GetValueOrDefault(0));
            double maxH = lineElevationData.Max(p => p.Elevation.GetValueOrDefault(0));
            double H = maxH - minH;
            double ratio_11 = lineElevationData.Last().DistanceFromOriginMeters / H;
            double ratio = ratio_11 / 4;
            double tolerance = H / DEFAULT_HEIGHT;

            // Make 4:1 geom
            SqlGeometryBuilder gb = new SqlGeometryBuilder();
            gb.SetSrid(0); // custom SRID
            gb.BeginGeometry(OpenGisGeometryType.LineString);

            gb.BeginFigure(lineElevationData[0].DistanceFromOriginMeters / ratio, lineElevationData[0].Elevation.GetValueOrDefault(0));
            for (int i = 1; i < lineElevationData.Count; i++)
            {
                gb.AddLine(lineElevationData[i].DistanceFromOriginMeters / ratio, lineElevationData[i].Elevation.GetValueOrDefault(0));
            }
            gb.EndFigure();
            gb.EndGeometry();
            SqlGeometry geom = gb.ConstructedGeometry;
            geom = DEM.Net.Lib.SqlTypesExtensions.MakeValidIfInvalid(geom,1);
            SpatialTrace.Enable();
            SpatialTrace.TraceGeometry(geom, message);
            SpatialTrace.Disable();


        }

        private static IEnumerable<T> GetNth<T>(List<T> list, int n)
        {
            for (int i = 0; i < list.Count; i += n)
                yield return list[i];

            if (list.Count % n != 0)
            {
                yield return list.Last();
            }
        }

        static DEM.Net.Lib.BoundingBox GetBoundingBox(string wkt, double buffer = 60)
        {
            SqlGeometry geom = GeometryService.ParseWKTAsGeometry(wkt);
            return geom.ToGeography().STBuffer(60).GetBoundingBox();
        }

        static void SpatialTrace_GeometryWithDEMGrid(ElevationService elevationService, IGeoTiffService geoTiffService, string wktBbox, DEMDataSet dataSet, double rangeKm = 100)
        {
            SpatialTrace.Enable();
            SpatialTrace.Clear();
            DEM.Net.Lib.BoundingBox bbox = null;
            if (wktBbox != null)
            {
                SqlGeometry geom = GeometryService.ParseWKTAsGeometry(wktBbox);
                SpatialTrace.TraceGeometry(geom, "Bbox");
                bbox = geom.ToGeography().STBuffer(rangeKm * 1000).GetBoundingBox();
            }


            Dictionary<string, DemFileReport> tiles = geoTiffService.GenerateReport(dataSet, bbox);

            SpatialTrace.Indent("DEM tiles");
            SpatialTrace.SetLineColor(Colors.Black);
            foreach (var tile in tiles)
            {
                SpatialTrace.SetFillColor(tile.Value.IsExistingLocally ? Color.FromArgb(128, 0, 255, 0) : Color.FromArgb(128, 255, 0, 0));

                SqlGeometry tileBbox = tile.Value.Source.BBox.AsGeomety();
                SpatialTrace.TraceGeometry(tileBbox, $"{tile.ToString()}");
            }
            SpatialTrace.Unindent();

            // View spatial trace in bin\debug with spatial trace viewer
            SpatialTrace.ShowDialog();
            SpatialTrace.Disable();

        }

        #region Sample WKT

        const string WKT_LEAFLET_ELEVATION = "LINESTRING (168.8317108154297 -44.94050129176629, 168.8459587097168 -44.955809372910416, 168.848876953125 -44.97779240834841, 168.85248184204102 -44.97718525532359, 168.8550567626953 -44.98192087842437, 168.85986328124997 -44.976699528274985, 168.86045336723328 -44.97628210330533, 168.86054992675778 -44.97553073070262, 168.86048555374146 -44.97530304009142, 168.86064648628235 -44.97528786068519, 168.86098980903625 -44.97662363305197, 168.86057138442993 -44.97750401146322, 168.860582113266 -44.97766338886854, 168.86087179183957 -44.977549547909945, 168.861483335495 -44.97668434923842, 168.86203050613403 -44.97478693802567, 168.86190176010132 -44.97419493287766, 168.86213779449463 -44.97411903433977, 168.86271715164185 -44.975561089382474, 168.8627815246582 -44.97615308042723, 168.86269569396973 -44.977079002883286, 168.86286735534668 -44.97720043422757, 168.86303901672363 -44.97666917019783, 168.8634467124939 -44.97632005115541, 168.86359691619873 -44.97601646765165, 168.86376857757568 -44.97609236367826, 168.86338233947754 -44.97676024438107, 168.86338233947754 -44.97710936074347, 168.86361837387085 -44.976790602410006, 168.8642406463623 -44.97574324112409, 168.86447668075562 -44.975075348576155, 168.86426210403442 -44.973587741761975, 168.86432647705078 -44.97326896385271, 168.86471271514893 -44.973177884124595, 168.86484146118164 -44.973921697671166, 168.86520624160767 -44.97522714302011, 168.86584997177124 -44.97551555135667, 168.8679313659668 -44.97551555135667, 168.8701629638672 -44.97650220048621, 168.87183666229248 -44.97780758709166, 168.8729953765869 -44.97800491038828, 168.87451887130737 -44.97747365381198, 168.87647151947021 -44.97674506536057, 168.87743711471558 -44.97635040941739, 168.8797116279602 -44.97581913751233, 168.88376712799072 -44.97367882083916, 168.88492584228516 -44.97360292161822, 168.89591217041016 -44.97815669707746, 168.89805793762204 -44.9786424117827, 168.90320777893066 -44.98525986470683, 168.90295028686523 -44.98683822689014, 168.90483856201172 -44.98774880068876, 168.90432357788086 -44.989509202350106, 168.9060401916504 -44.991694453332975, 168.90870094299316 -44.991694453332975, 168.90955924987793 -44.99278704758026, 168.91342163085938 -44.992908445655296, 168.918399810791 -44.992119353570914, 168.91779899597165 -44.99448659722985, 168.9199447631836 -44.99491147676692, 168.92020225524902 -44.99539704952342, 168.9246654510498 -44.99563983435874, 168.927583694458 -44.99545774582868, 168.93161773681638 -44.993576130471396, 168.93736839294434 -44.99187655382068, 168.93874168395996 -44.99187655382068, 168.94123077392578 -44.985927638626634, 168.9426040649414 -44.98088878877439, 168.9447498321533 -44.9788245537364, 168.94569396972656 -44.97657809586995, 168.95024299621582 -44.97408867489649, 168.9521312713623 -44.97372436032352, 168.95822525024414 -44.96753065848274, 168.95916938781735 -44.96516230160631, 168.95891189575195 -44.962733116054906, 168.9571952819824 -44.960364561106104, 168.95736694335938 -44.95775296410428, 168.95659446716306 -44.954533855413004, 168.95985603332517 -44.95113233681429, 168.96140098571777 -44.945908183564796, 168.96406173706055 -44.94159486152485, 168.9663791656494 -44.94025827343572, 168.96921157836914 -44.93624832247523, 168.96989822387695 -44.932055801594124, 168.97067070007324 -44.92907831829959, 168.9718723297119 -44.92622221990126, 168.97101402282712 -44.92391293013678, 168.9734172821045 -44.91753151524949, 168.97290229797363 -44.915829684908374, 168.97479057312012 -44.91406702177809, 168.9766788482666 -44.91193959772162, 168.97976875305176 -44.908778707989505, 168.9868068695068 -44.90008536489001, 168.98929595947266 -44.89582940298676, 168.99118423461914 -44.893701303905985, 168.99538993835446 -44.892120379322776, 168.99916648864746 -44.888289497216874, 169.00405883789062 -44.8813567762342, 169.00543212890625 -44.878011743648976, 169.00972366333008 -44.87424074647194, 169.01453018188477 -44.87126026742077, 169.01787757873535 -44.864264659332704, 169.02182579040527 -44.86037108311342, 169.02766227722168 -44.857146515983025, 169.03950691223145 -44.85051429145943, 169.04534339904782 -44.84601124502415, 169.05624389648438 -44.83396082207883, 169.06070709228516 -44.82982171157174, 169.0689468383789 -44.80449362243493, 169.08714294433594 -44.78037289410103, 169.1012191772461 -44.75794863467063, 169.1238784790039 -44.747708578336145, 169.13177490234375 -44.74356327779896, 169.13692474365234 -44.725515565201384, 169.13555145263672 -44.698189394754145)";
        const string WKT_SCL_MENDOZA = "LINESTRING (-70.66131591796875 -33.45435978951701, -70.74234008789062 -33.29380355834659, -70.6915283203125 -33.14215083110535, -70.68466186523438 -32.8922726541885, -70.64346313476562 -32.82074894982262, -70.46493530273438 -32.828827094089085, -70.345458984375 -32.82074894982262, -70.22048950195312 -32.802281861547314, -70.09414672851562 -32.795355714148315, -69.91012573242188 -32.83344284664949, -69.68490600585938 -32.832288931002395, -69.46929931640624 -32.83805835927704, -69.14794921875 -32.83805835927704, -68.83621215820312 -32.88881315761995)";
        const string WKT_SANTIAGO_EL_PLOMO = "LINESTRING (-70.79933166503906 -33.55598734171233, -70.213371 -33.236214)";
        const string WKT_VUE_MAISON = "LINESTRING (5.446987152099609 43.542482399204786, 5.58079719543457 43.53100253601927)";
        const string WKT_STE_VICTOIRE_A8 = "LINESTRING (5.57830810546875 43.4249985081581, 5.575561523437499 43.555515149559746)";
        const string WKT_PLATEAU_PUYRICARD = "LINESTRING (5.447373390197754 43.54238907579587, 5.445485115051269 43.54260683019196, 5.445613861083984 43.544379943853905, 5.445270538330078 43.54525092795516, 5.445442199707031 43.546961752945364, 5.445613861083984 43.54764606934588, 5.445613861083984 43.54801932956258, 5.445184707641602 43.54910799199228, 5.444240570068359 43.55041436095265, 5.444025993347167 43.55134746430302, 5.443682670593262 43.55389787308514, 5.443682670593262 43.55489312528296, 5.443940162658691 43.55560845264746, 5.443382263183594 43.55685248001281, 5.442523956298828 43.55962034875577, 5.44222354888916 43.56251248024762, 5.441923141479492 43.56372526826544, 5.441751480102539 43.56636843960813, 5.441622734069824 43.56770552917119, 5.440893173217773 43.570503992650366, 5.440464019775391 43.57174771246127, 5.440206527709961 43.57339560165024, 5.439519882202148 43.575012354767935, 5.439176559448241 43.5778726578)";
        const string WKT_HORIZONTAL_DEM_EDGE = "LINESTRING (6.1 43.99, 6.9 44.01)";
        const string WKT_VERTICAL_DEM_EDGE = "LINESTRING (6.001 43.1, 5.99 43.9)";
        const string WKT_MONACO = "LINESTRING (7.0806884765625 45.37916094640917, 7.48443603515625 43.77307711737606)";
        const string WKT_TEST = "LINESTRING (8.668212890625 40.58058466412761, 5.438232421875 43.389081939117496)";
        const string WKT_NO_DEM = "LINESTRING (7.492675781249999 41.582579601430346, 7.5146484375 39.791654835253425)";
        const string WKT_ZERO = "LINESTRING(-4.36763906478882	48.4062232971191, -4.35986089706421	48.4028930664063)";
        const string WKT_NEG100 = "LINESTRING(-4.04486131668091	48.2679634094238, -4.03826761245728	48.2651405334473)";
        const string WKT_BREST_SPAIN_OCEAN = "LINESTRING(-4.519500732421875 43.373509919227104,-4.47418212890625 48.39966209090939)";
        const string WKT_EXAMPLE_GOOGLE = "LINESTRING(-118.291994 36.578581,-116.83171 36.23998)";
        const string WKT_BREST_NICE = "LINESTRING(-4.482421875 48.45539196446375,6.943359375 43.5612374716474)";
        const string WKT_PARIS_AIX = "LINESTRING(2.340087890625 48.87047363512827,2.362060546875 48.71124007358497,2.581787109375 48.376663195419056,3.043212890625 48.091266595037794,3.31787109375 47.92220925866507,3.779296875 47.789516887184,4.010009765625 47.48600498307925,4.39453125 47.426577530514564,4.833984375 47.068601854632306,4.833984375 46.86617699946977,4.921875 46.35297057957134,4.735107421875 46.102161444290594,4.779052734375 45.80427288878466,4.81201171875 45.46627091868822,4.910888671875 44.9321165649521,4.7021484375 44.282939125313995,4.888916015625 44.01491649204199,5.1416015625 43.554893125282966,5.460205078125 43.53896711771029)";
        const string WKT_GRANDE_BOUCLE = "LINESTRING(5.4471588134765625 43.54239685275213,5.447598695755005 43.54232686010967,5.448499917984009 43.54240462970736,5.450270175933838 43.54189912552898,5.451364517211914 43.54155693567945,5.451589822769165 43.54143250252535,5.452630519866943 43.5414247254447,5.452491044998169 43.54078700141682,5.453864336013794 43.54060034920576,5.454164743423462 43.541385840026344,5.455001592636108 43.54261460712012,5.455162525177002 43.54268459942852,5.455119609832764 43.54283236070161,5.454883575439453 43.54277014547287,5.453628301620483 43.54329897287061,5.452373027801514 43.54342340217237,5.452415943145752 43.54387445623844,5.452297925949097 43.544457710803165,5.452029705047607 43.54497874677534,5.452061891555786 43.545134279028574,5.4524266719818115 43.545305364043664,5.452308654785156 43.54640185193005,5.45246958732605 43.54694620020958,5.452094078063965 43.54795711968697,5.452297925949097 43.54830704940204,5.451525449752808 43.54905355933778,5.451074838638306 43.549014678840194,5.450838804244995 43.54906133543429,5.4500555992126465 43.54995557984124,5.449733734130859 43.550849810980594,5.449916124343872 43.55092756958308,5.450259447097778 43.55180623481941,5.450087785720825 43.552140590792334,5.449733734130859 43.55249827187253,5.449519157409668 43.553019238343815,5.4480063915252686 43.55332248541017,5.447877645492554 43.5532680565619,5.4470837116241455 43.55270043850059,5.447072982788086 43.55255270141602,5.449637174606323 43.55090424201289,5.449744462966919 43.55084203511484,5.449948310852051 43.55034437761901,5.450077056884766 43.549940027877945,5.450377464294434 43.549574555585714,5.448800325393677 43.54892136554366,5.448875427246094 43.54864142478726,5.448735952377319 43.54834593035609,5.448349714279175 43.54784047599715,5.447491407394409 43.54718726716287,5.44721245765686 43.54707062198327,5.446654558181763 43.5473272410804,5.44622540473938 43.547412780536675,5.4457855224609375 43.54737389898068,5.445528030395508 43.547412780536675,5.445120334625244 43.54584972222492,5.445195436477661 43.54501762987626,5.445624589920044 43.54444215742132,5.445399284362793 43.542715707095056,5.445302724838257 43.5425912763326,5.445420742034912 43.54254461473046,5.445570945739746 43.54261460712012,5.4471588134765625 43.54239685275213)";
        const string WKT_PETITE_BOUCLE = "LINESTRING(5.44771671295166 43.54234241403722,5.450162887573242 43.54196911866801,5.452415943145752 43.541378062939685,5.452544689178467 43.54070922973245,5.453896522521973 43.54063145794773,5.454990863800049 43.542715707095056,5.453681945800781 43.543275642347915,5.4500555992126465 43.544177749316354,5.448317527770996 43.544768777596964,5.445957183837891 43.54703951656395,5.44546365737915 43.547506096168696,5.445120334625244 43.54526648112833,5.445678234100342 43.544177749316354,5.445399284362793 43.54256016860185,5.44771671295166 43.54234241403722)";
        const string WKT_GRAND_TRAJET = "LINESTRING(5.447738170623779 43.54234241403722,5.4471588134765625 43.54238907579587,5.4467082023620605 43.54249795309221,5.445442199707031 43.54263793789861,5.445570945739746 43.544457710803165,5.445120334625244 43.545313140623726,5.445120334625244 43.54605968763827,5.4454851150512695 43.54755275393054,5.445050597190857 43.54756830650979,5.444814562797546 43.54747499097408,5.44447660446167 43.547319464760186,5.4441118240356445 43.547319464760186,5.443317890167236 43.54747110282363,5.44297456741333 43.54743610945823,5.442625880241394 43.54730002395522,5.442357659339905 43.54709395103727,5.4420894384384155 43.54691898291237,5.441558361053467 43.54686066009121,5.441048741340637 43.54690731835265,5.440464019775391 43.54705895745292,5.440303087234497 43.547163938145005,5.440260171890259 43.54748665542395,5.4400938749313354 43.54761107608205,5.439755916595459 43.547661621901064,5.439584255218506 43.54812042047349,5.439535975456238 43.548551998993865,5.439498424530029 43.549636763791966,5.439112186431885 43.55005666750473,5.436794757843018 43.55179845907704,5.4358720779418945 43.55228055320695,5.435550212860107 43.552902604450466,5.435013771057129 43.553275832114664,5.434691905975342 43.553213627664476,5.434584617614746 43.55259157963129,5.434906482696533 43.552296104566295,5.434370040893555 43.55102087977367,5.433297157287598 43.550538775567375,5.431044101715088 43.54999445973189,5.429842472076416 43.549870043993536,5.428211688995361 43.55019663475889,5.427310466766357 43.55010332329225,5.426774024963379 43.54962121174641,5.426902770996094 43.548936917769765,5.427439212799072 43.5485014539215,5.4283833503723145 43.54730391211671,5.432267189025879 43.54119141255846,5.432717800140381 43.54008705264584,5.432631969451904 43.53862491121964,5.4320526123046875 43.53730273153031,5.426838397979736 43.52692650336303,5.426516532897949 43.52547960110387,5.426580905914307 43.52390819482177,5.427052974700928 43.522072242564995,5.428190231323242 43.51914705066751,5.428404808044434 43.5178400041918,5.428125858306885 43.51623727760756,5.427138805389404 43.51440109191845,5.4253363609313965 43.51287608167312,5.423233509063721 43.51200462994486,5.419907569885254 43.51124209936016,5.416581630706787 43.51010606653939,5.41301965713501 43.508300819714854,5.411109924316406 43.50694684916336,5.409865379333496 43.50582629884247,5.408470630645752 43.50398979639134,5.406968593597412 43.50089251739086,5.406453609466553 43.49846438857513,5.406582355499268 43.49513333506259,5.406625270843506 43.49427719349613,5.406560897827148 43.49329650733292,5.4062819480896 43.49320310782013,5.405981540679932 43.49331207390435,5.404994487762451 43.49480644607877,5.404157638549805 43.495569184288435,5.402441024780273 43.4985733451658,5.402162075042725 43.49805969094556,5.401604175567627 43.49712576298661,5.401303768157959 43.49588050323809,5.401153564453125 43.494977673862394,5.401260852813721 43.49385690137624,5.400681495666504 43.49317197461708,5.400488376617432 43.49187993253735,5.400831699371338 43.49077466978604,5.401153564453125 43.48904668326483,5.400295257568359 43.4879102327493,5.399415493011475 43.48706955696546,5.398836135864258 43.48649353161793,5.396690368652344 43.483021694960314,5.394952297210693 43.48095095299566,5.39379358291626 43.47917597482142,5.388686656951904 43.48093538323836,5.384116172790527 43.48292827955829,5.3827643394470215 43.484236082041896,5.38029670715332 43.482165381701805,5.37954568862915 43.481277916971784,5.377528667449951 43.479425097710845,5.376412868499756 43.47880228856128,5.375125408172607 43.47782135113263,5.373859405517578 43.47853759272874,5.372421741485596 43.47861544456456,5.371134281158447 43.478989131980235,5.369589328765869 43.47771235710197,5.368494987487793 43.47705838878934,5.368280410766602 43.47696496416688,5.367722511291504 43.476575693351926,5.368366241455078 43.474707158532745,5.368945598602295 43.47375729784957)";
        const string WKT_GRAND_TRAJET_MARSEILLE_ALPES_MULTIPLE_TILES = "LINESTRING(5.38330078125 43.27920492608278,5.36407470703125 43.305193797650546,5.3778076171875 43.32717570677798,5.350341796875 43.38508989465155,5.3778076171875 43.42699324866588,5.41900634765625 43.488797600050006,5.4327392578125 43.518680251604984,5.46844482421875 43.58039085560783,5.49591064453125 43.62215891380658,5.4876708984375 43.661911057260674,5.548095703125 43.655949912568225,5.6304931640625 43.65793702655821,5.6689453125 43.685749717616766,5.73760986328125 43.70163689691259,5.9051513671875 43.935483850319756,5.9820556640625 44.12308489306967,5.91064453125 44.315987905196906,5.9710693359375 44.422011314236634,6.053466796875 44.484749436619964,6.082305908203125 44.562098859191025,6.087799072265625 44.66083904265623,6.0150146484375 44.72575949075228,6.0047149658203125 44.76014269639826,6.040763854980469 44.77951995657652,6.079730987548828 44.791886317441076,6.115350723266602 44.81341451906245,6.139340400695801 44.825636646910226,6.173994541168213 44.81908450825152,6.222563982009888 44.822139982642284,6.260833740234375 44.82763029742813)";
        const string WKT_BAYONNE_AIX_OUEST_EST = "LINESTRING(-1.56005859375 43.444942955261254,-1.263427734375 43.548548110912854,-0.87890625 43.51668853502907,-0.428466796875 43.35713822211053,-0.10986328125 43.24520272203356,0.28564453125 43.17313537107136,0.41748046875 43.092960677116295,0.999755859375 43.12504316740127,1.1865234375 43.28520334369384,1.439208984375 43.620170616189895,1.571044921875 43.476840397778936,2.032470703125 43.229195113965,2.65869140625 43.15710884095329,2.999267578125 43.14909399920127,3.438720703125 43.36512572875844,3.97705078125 43.644025847699496,4.361572265625 43.81867485545321,4.658203125 43.65197548731187,5.130615234375 43.620170616189895,5.42724609375 43.532620426810105)";
        const string WKT_AIX_BAYONNE_EST_OUEST = "LINESTRING(5.44921875 43.532620426810105,5.152587890625 43.628123412124616,4.647216796875 43.67581809328341,4.306640625 43.84245116699039,3.93310546875 43.644025847699496,3.2080078125 43.30919109985686,2.96630859375 43.12504316740127,2.30712890625 43.189157696549216,1.669921875 43.40504748787035,1.439208984375 43.65197548731187,1.318359375 43.46089378008257,1.16455078125 43.27720532212024,0.933837890625 43.117024121350475,0.384521484375 43.08493742707592,0.142822265625 43.205175817237304,-0.3955078125 43.34116005412307,-1.07666015625 43.54058479482877,-1.494140625 43.48481212891604)";
        const string WKT_BAYONNE_NICE_DIRECT = "LINESTRING(-1.51611328125 43.50075243569041,7.261962890625 43.711564246658504)";
        const string WKT_DEM_INTERPOLATION_BUG = "LINESTRING(5.42859268188477 43.5304183959961, 5.42845249176025 43.5301399230957,5.4283127784729 43.5298614501953,5.42817258834839 43.5295829772949,5.42803287506104 43.5293045043945,5.42789268493652 43.5290260314941,5.4277548789978 43.528751373291,5.42761468887329 43.5284729003906)";

        const string WKT_POLY_FRANCE = "POLYGON ((-6.328125 41.21172151054787, 10.01953125 41.21172151054787, 10.01953125 51.37178037591737, -6.328125 51.37178037591737, -6.328125 41.21172151054787))";


        #endregion
    }
}