namespace HexadecaTree
{
    public class HexadecaParameters
    {
        public readonly long maxLong = 9223372036854775807;
        public double Resolution_X { get; set; } = 10.0; // units per mm: 1 cm
        public double Resolution_Y { get; set; } = 10.0; // units per mm: 1 cm
        public double Resolution_Z { get; set; } = 10.0; // units per mm: 1 cm
        public double Resolution_T { get; set; } = 1000000000000.0; // units per picosecond: 1 second
        //                                   9223372036854775807
        public bool SetSpatialResolutions(double[] resolutions)
        {
            return true;
        }
        /// <summary>
        /// SetSpeedOfCausality
        /// This is the maximum relative speed with which objects can interact. 
        /// This constrains the region within which there is locality of interaction,
        /// which reduce the spatial region for searches and also sets
        /// a granularity in the time coordinate. The speed must be greater than or equal to zero
        /// (statis environments) and less than or equal to the speed of light in vacuum.
        /// </summary>
        /// <param name="speed">millimeters per picosecond 
        /// or meters per nanosecond</param>
        /// <returns>nool indicating success or failure - failure results in no change</returns>
        public bool SetSpeedOfCausality(double speed) 
        { 
            return true; 
        }
    }
    // 128-bit node: gargantini 16-tree plus 28-bit payload: parameter block index, semantic system index
    // semantic system
    // semantic class (hierarchy?)
    // 
    public class HexadecaTree
    {
        // given a x,y.z,t return a hdtree hash
        // given a hdtree hash, retuen x,y,z,t
        // define resolution of a hdtree as delta x, delta y, delta z, delta st
        // given speed of causal interaction (sci) in mm/sec, return delta t
        // note: space units are mm
        // note: clock-time units are picoseconds
        // note: time units are mm = sci * delta t, where delta t is in picoseconds
        //        for example, static environments sci = 0 and delta t  is zero
        //        for example. for automobiles sci = (100 m/sec * 1000 mm/m) / 1 000 000 000 000 = 0.0000001 mm/ps
        //        for example, for light sci = (300 000 000 m/sec * 1000 mm/m) / 1 000 000 000 000 = 0.3 mm / ps
        // 
    }
}
