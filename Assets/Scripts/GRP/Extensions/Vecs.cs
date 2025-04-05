#define GRPU_EXTENSIONS_VECS

#if !GRPU_EXTENSIONS_FORCE_DISABLE && (GRPU_EXTENSIONS_ENABLE_ALL || GRPU_EXTENSIONS_VECS)
#define __GRPU_EXT_VECS
#else
// Just in case
#undef __GRPU_EXT_VECS
#endif

using System.Runtime.CompilerServices;
using UnityEngine;

using UV2 = UnityEngine.Vector2;
using UV2I = UnityEngine.Vector2Int;
using UV3 = UnityEngine.Vector3;
using UV3I = UnityEngine.Vector3Int;
using UV4 = UnityEngine.Vector4;

using SNV2 = System.Numerics.Vector2;
using SNV3 = System.Numerics.Vector3;
using SNV4 = System.Numerics.Vector4;
using System;

namespace GRPU.Extensions
{
    public static partial class GRPU_Vecs
    {
        public struct Bool3
        {
            public bool x, y, z;

            public Bool3( bool b )
            {
                x = b;
                y = b;
                z = b;
            }

            public Bool3( bool x, bool y, bool z )
            {
                this.x = x; 
                this.y = y; 
                this.z = z;
            }

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public bool All() => x && y && z;
            
            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public bool Any() => x || y || z;

            [MethodImpl( MethodImplOptions.AggressiveInlining )]
            public static implicit operator bool( Bool3 b3 ) => b3.All();
        }

        #region Static methods
        // Fill
        /// <summary>
        /// Constructs a Vector2 with n as all of its components.
        /// </summary>
        /// <param name="n">Number to fill the Vector2 with.</param>
        /// <returns>Vector2 with n as all of its components.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2 Fill2(float n) => new UV2(n, n);

        /// <summary>
        /// Constructs a Vector2Int with n as all of its components.
        /// </summary>
        /// <param name="n">Number to fill the Vector2Int with.</param>
        /// <returns>Vector2Int with n as all of its components.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2I Fill2Int(int n) => new UV2I(n, n);

        /// <summary>
        /// Constructs a Vector3 with n as all of its components.
        /// </summary>
        /// <param name="n">Number to fill the Vector3 with.</param>
        /// <returns>Vector3 with n as all of its components.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 Fill3(float n) => new UV3(n, n, n);

        /// <summary>
        /// Constructs a Vector3Int with n as all of its components.
        /// </summary>
        /// <param name="n">Number to fill the Vector3Int with.</param>
        /// <returns>Vector3Int with n as all of its components.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I Fill3Int(int n) => new UV3I(n, n, n);

        /// <summary>
        /// Constructs a Vector4 with n as all of its components.
        /// </summary>
        /// <param name="n">Number to fill the Vector4
        /// with.</param>
        /// <returns>Vector4
        /// with n as all of its components.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 Fill4(float n) => new UV4(n, n, n, n);
        #endregion

        #region UnityEngine's Vectors extensions
        // Set[Axis]
        // X
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetX(
#if __GRPU_EXT_VECS
            this
#endif
            ref UV2 v, float newX ) => v.x = newX;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetX(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV2I v, int newX ) => v.x = newX;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetX(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV3 v, float newX ) => v.x = newX;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetX(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV3I v, int newX ) => v.x = newX;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetX(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV4 v, float newX ) => v.x = newX;

        // Y
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetY(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV2 v, float newY ) => v.y = newY;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetY(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV2I v, int newY ) => v.y = newY;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetY(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV3 v, float newY ) => v.y = newY;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetY(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV3I v, int newY ) => v.y = newY;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetY(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV4 v, float newY ) => v.y = newY;

        // Z
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetZ(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV3 v, float newZ ) => v.z = newZ;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetZ(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV3I v, int newZ ) => v.z = newZ;

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetZ(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV4 v, float newZ ) => v.z = newZ;

        // W
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static void SetW(
#if __GRPU_EXT_VECS
            this
#endif
             ref UV4 v, float newW ) => v.w = newW;

        // With[Axis]
        // X
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2 WithX(
#if __GRPU_EXT_VECS
            this
#endif
             UV2 v, float newX ) => new( newX, v.y );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2I WithX(
#if __GRPU_EXT_VECS
            this
#endif
             UV2I v, int newX ) => new( newX, v.y );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 WithX(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, float newX ) => new( newX, v.y, v.z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I WithX(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, int newX ) => new( newX, v.y, v.z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithX(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newX ) => new( newX, v.y, v.z, v.w );

        // Y
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2 WithY(
#if __GRPU_EXT_VECS
            this
#endif
             UV2 v, float newY ) => new( v.x, newY );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2I WithY(
#if __GRPU_EXT_VECS
            this
#endif
             UV2I v, int newY ) => new( v.x, newY );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 WithY(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, float newY ) => new( v.x, newY, v.z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I WithY(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, int newY ) => new( v.x, newY, v.z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithY(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newY ) => new( v.x, newY, v.z, v.w );

        // Z
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 WithZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, float newZ ) => new( v.x, v.y, newZ );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I WithZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, int newZ ) => new( v.x, v.y, newZ );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newZ ) => new( v.x, v.y, newZ, v.w );

        // W
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithW(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newW ) => new( v.x, v.y, v.z, newW );

        // With[Axes]
        // XY
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 WithXY(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, float newX, float newY ) => new( newX, newY, v.z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I WithXY(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, int newX, int newY ) => new( newX, newY, v.z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithXY(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newX, float newY ) => new( newX, newY, v.z, v.w );

        // XZ
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 WithXZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, float newX, float newZ ) => new( newX, v.y, newZ );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I WithXZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, int newX, int newZ ) => new( newX, v.y, newZ );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithXZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newX, float newZ ) => new( newX, v.y, newZ, v.w );

        // YZ
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 WithYZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, float newY, float newZ ) => new( v.x, newY, newZ );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I WithYZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, int newY, int newZ ) => new( v.x, newY, newZ );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithYZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newY, float newZ ) => new( v.x, newY, newZ, v.w );

        // XW
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithXW(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newX, float newW ) => new( newX, v.y, v.z, newW );

        // YW
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithYW(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newY, float newW ) => new( v.x, newY, v.z, newW );

        // ZW
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithZW(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newZ, float newW ) => new( v.x, v.y, newZ, newW );

        // XYZ
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithXYZ(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newX, float newY, float newZ ) => new( newX, newY, newZ, v.w );

        // XZW
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithXZW(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newX, float newZ, float newW ) => new( newX, v.y, newZ, newW );

        // YZW
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 WithYZW(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, float newY, float newZ, float newW ) => new( v.x, newY, newZ, newW );


        // System.Numerics.Vector & UnityEngine.Vector
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static SNV2 ToNumerics(
#if __GRPU_EXT_VECS
            this
#endif
             UV2 v ) => new SNV2( v.x, v.y );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static SNV3 ToNumerics(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v ) => new SNV3( v.x, v.y, v.z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static SNV4 ToNumerics(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v ) => new SNV4( v.x, v.y, v.z, v.w );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2 ToUnity(
#if __GRPU_EXT_VECS
            this
#endif
             SNV2 v ) => new UV2( v.X, v.Y );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 ToUnity(
#if __GRPU_EXT_VECS
            this
#endif
             SNV3 v ) => new UV3( v.X, v.Y, v.Z );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 ToUnity(
#if __GRPU_EXT_VECS
            this
#endif
             SNV4 v ) => new UV4( v.X, v.Y, v.Z, v.W );

        // Map (Vector map)
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2 MapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV2 v, Func<float, float> f ) => new( f( v.x ), f( v.y ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2I MapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV2I v, Func<int, int> f ) => new( f( v.x ), f( v.y ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 MapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, Func<float, float> f ) => new( f( v.x ), f( v.y ), f( v.z ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I MapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, Func<int, int> f ) => new( f( v.x ), f( v.y ), f( v.z ) );
        
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 MapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, Func<float, float> f ) => new( f( v.x ), f( v.y ), f( v.z ), f( v.w ) );

        // MapI (Vector map with index)
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2 MapI(
#if __GRPU_EXT_VECS
            this
#endif
             UV2 v, Func<float, int, float> f ) => new( f( v.x, 0 ), f( v.y, 1 ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2I MapI(
#if __GRPU_EXT_VECS
            this
#endif
             UV2I v, Func<int, int, int> f )   => new( f( v.x, 0 ), f( v.y, 1 ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 MapI(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, Func<float, int, float> f ) => new( f( v.x, 0 ), f( v.y, 1 ), f( v.z, 2 ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I MapI(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, Func<int, int, int> f )   => new( f( v.x, 0 ), f( v.y, 1 ), f( v.z, 2 ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 MapI(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, Func<float, int, float> f ) => new( f( v.x, 0 ), f( v.y, 1 ), f( v.z, 2 ), f( v.w, 3 ) );

        // MapI (Vector map with index)
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2 ZipMapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV2 v, UV2 u, Func<float, float, float> f ) => new( f( v.x, u.x ), f( v.y, u.y ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV2I ZipMapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV2I v, UV2I u, Func<int, int, int> f )    => new( f( v.x, u.x ), f( v.y, u.y ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3 ZipMapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV3 v, UV3 u, Func<float, float, float> f ) => new( f( v.x, u.x ), f( v.y, u.y ), f( v.z, u.z ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV3I ZipMapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV3I v, UV3I u, Func<int, int, int> f )    => new( f( v.x, u.x ), f( v.y, u.y ), f( v.z, u.z ) );

        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public static UV4 ZipMapV(
#if __GRPU_EXT_VECS
            this
#endif
             UV4 v, UV4 u, Func<float, float, float> f ) => new( f( v.x, 0 ), f( v.y, u.y ), f( v.z, u.z ), f( v.w, u.w ) );
        #endregion
    }
}
