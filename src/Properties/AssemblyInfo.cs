﻿using System.Reflection;
using System.Runtime.InteropServices;
using UniverseLib;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(UniverseLib.Universe.NAME)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(UniverseLib.Universe.AUTHOR)]
[assembly: AssemblyProduct(UniverseLib.Universe.NAME)]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b21dbde3-5d6f-4726-93ab-cc3cc68bae7d")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(UniverseLib.Universe.VERSION)]
[assembly: AssemblyFileVersion(UniverseLib.Universe.VERSION)]
[assembly: KSPAssembly("UniverseLibKSP", 1, 0)]
[assembly: KSPAssemblyDependency("HarmonyKSP", 1, 0)]