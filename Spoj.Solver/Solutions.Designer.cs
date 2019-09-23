﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spoj.Solver {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Solutions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Solutions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Spoj.Solver.Solutions", typeof(Solutions).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///// https://www.spoj.com/problems/ADDREV/
        ///// Reverses two integers then sums them then returns the reversed sum.
        ///public static class ADDREV
        ///{
        ///    public static int Solve(int x, int y)
        ///        =&gt; Reverse(Reverse(x) + Reverse(y));
        ///
        ///    private static int Reverse(int x)
        ///    {
        ///        var a = x.ToString().ToCharArray();
        ///        Array.Reverse(a);
        ///
        ///        return int.Parse(new string(a));
        ///    }
        ///}
        ///
        ///public static class Program
        ///{
        ///    private static void Main()
        ///    {
        ///        var li [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ADDREV {
            get {
                return ResourceManager.GetString("ADDREV", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///
        ///// https://www.spoj.com/problems/ARMY/
        ///public static class ARMY
        ///{
        ///    public static string Solve(int[] godzillasArmy, int[] mechasArmy)
        ///        =&gt; godzillasArmy.Max() &gt;= mechasArmy.Max() ? &quot;Godzilla&quot; : &quot;MechaGodzilla&quot;;
        ///}
        ///
        ///public static class Program
        ///{
        ///    private static void Main()
        ///    {
        ///        var numberOfBattles = int.Parse(Console.ReadLine());
        ///
        ///        for (int b = 0; b &lt; numberOfBattles; b++)
        ///        {
        ///            Co [rest of string was truncated]&quot;;.
        /// </summary>
        public static string ARMY {
            get {
                return ResourceManager.GetString("ARMY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #ad-hoc
        ///#bfs
        ///#big-numbers
        ///#binary
        ///#binary-search
        ///#bit
        ///#bitmask
        ///#bst
        ///#buckets
        ///#combinatorics
        ///#dag
        ///#deque
        ///#dfs
        ///#digits
        ///#dijkstras
        ///#disjoint-sets
        ///#divide-and-conquer
        ///#division
        ///#dynamic-programming
        ///#dynamic-programming-1d
        ///#dynamic-programming-2d
        ///#dynamic-programming-3d
        ///#euler-path
        ///#factorial
        ///#factors
        ///#formula
        ///#game
        ///#gcd
        ///#golf
        ///#graph-theory
        ///#greedy
        ///#hash-table
        ///#heap
        ///#hld
        ///#io
        ///#knapsack
        ///#lazy
        ///#lca
        ///#longest-path
        ///#math
        ///#memoization
        ///#merge
        ///#mod-math
        ///#mst
        ///#offline
        ///#optimiza [rest of string was truncated]&quot;;.
        /// </summary>
        public static string Tags {
            get {
                return ResourceManager.GetString("Tags", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///
        ///// https://www.spoj.com/problems/TEST/
        ///public static class TEST
        ///{
        ///    public static void Solve()
        ///    {
        ///        string line;
        ///        while ((line = Console.ReadLine()) != &quot;42&quot;)
        ///        {
        ///            Console.WriteLine(line);
        ///        }
        ///    }
        ///}
        ///
        ///public static class Program
        ///{
        ///    private static void Main()
        ///        =&gt; TEST.Solve();
        ///}.
        /// </summary>
        public static string TEST {
            get {
                return ResourceManager.GetString("TEST", resourceCulture);
            }
        }
    }
}
