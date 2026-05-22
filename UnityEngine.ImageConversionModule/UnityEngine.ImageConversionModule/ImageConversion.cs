using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class ImageConversion
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000021D0 File Offset: 0x000003D0
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		public static bool EnableLegacyPngGammaRuntimeLoadBehavior
		{
			get
			{
				return ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehavior();
			}
			set
			{
				ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehavior(value);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000205A File Offset: 0x0000025A
		public static bool GetEnableLegacyPngGammaRuntimeLoadBehavior()
		{
			return ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		public static void SetEnableLegacyPngGammaRuntimeLoadBehavior(bool enable)
		{
			ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField(enable);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021E8 File Offset: 0x000003E8
		public static Il2CppStructArray<byte> EncodeToTGA(Texture2D tex)
		{
			IntPtr intPtr = ImageConversion.EncodeToTGADelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002214 File Offset: 0x00000414
		public static Il2CppStructArray<byte> EncodeToPNG(Texture2D tex)
		{
			IntPtr intPtr = ImageConversion.EncodeToPNGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002240 File Offset: 0x00000440
		public static Il2CppStructArray<byte> EncodeToJPG(Texture2D tex, int quality)
		{
			IntPtr intPtr = ImageConversion.EncodeToJPGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex), quality);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002270 File Offset: 0x00000470
		public static Il2CppStructArray<byte> EncodeToJPG(Texture2D tex)
		{
			return ImageConversion.EncodeToJPG(tex, 75);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000228C File Offset: 0x0000048C
		public static Il2CppStructArray<byte> EncodeToEXR(Texture2D tex, Texture2D.EXRFlags flags)
		{
			IntPtr intPtr = ImageConversion.EncodeToEXRDelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex), flags);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022BC File Offset: 0x000004BC
		public static Il2CppStructArray<byte> EncodeToEXR(Texture2D tex)
		{
			return ImageConversion.EncodeToEXR(tex, Texture2D.EXRFlags.None);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002073 File Offset: 0x00000273
		public static bool LoadImage(Texture2D tex, Il2CppStructArray<byte> data, bool markNonReadable)
		{
			return ImageConversion.LoadImageDelegateField(IL2CPP.Il2CppObjectBaseToPtr(tex), IL2CPP.Il2CppObjectBaseToPtr(data), markNonReadable);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022D8 File Offset: 0x000004D8
		public static bool LoadImage(Texture2D tex, Il2CppStructArray<byte> data)
		{
			return ImageConversion.LoadImage(tex, data, false);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022F4 File Offset: 0x000004F4
		public static Il2CppStructArray<byte> EncodeArrayToTGA(Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToTGADelegateField(IL2CPP.Il2CppObjectBaseToPtr(array), format, width, height, rowBytes);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002328 File Offset: 0x00000528
		public static Il2CppStructArray<byte> EncodeArrayToPNG(Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToPNGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(array), format, width, height, rowBytes);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000235C File Offset: 0x0000055C
		public static Il2CppStructArray<byte> EncodeArrayToJPG(Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToJPGDelegateField(IL2CPP.Il2CppObjectBaseToPtr(array), format, width, height, rowBytes, quality);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002390 File Offset: 0x00000590
		public static Il2CppStructArray<byte> EncodeArrayToEXR(Array array, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags)
		{
			IntPtr intPtr = ImageConversion.EncodeArrayToEXRDelegateField(IL2CPP.Il2CppObjectBaseToPtr(array), format, width, height, rowBytes, flags);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000023C4 File Offset: 0x000005C4
		public unsafe static NativeArray<byte> EncodeNativeArrayToTGA<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToTGA(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002404 File Offset: 0x00000604
		public unsafe static NativeArray<byte> EncodeNativeArrayToPNG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToPNG(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002444 File Offset: 0x00000644
		public unsafe static NativeArray<byte> EncodeNativeArrayToJPG<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToJPG(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes, quality);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002484 File Offset: 0x00000684
		public unsafe static NativeArray<byte> EncodeNativeArrayToEXR<T>(NativeArray<T> input, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags) where T : struct
		{
			int num = input.Length * UnsafeUtility.SizeOf<T>();
			void* ptr = ImageConversion.UnsafeEncodeNativeArrayToEXR(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<T>(input), ref num, format, width, height, rowBytes, flags);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(ptr, num, Allocator.Persistent);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208C File Offset: 0x0000028C
		public unsafe static void* UnsafeEncodeNativeArrayToTGA(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToTGADelegateField(array, ref sizeInBytes, format, width, height, rowBytes);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020A0 File Offset: 0x000002A0
		public unsafe static void* UnsafeEncodeNativeArrayToPNG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToPNGDelegateField(array, ref sizeInBytes, format, width, height, rowBytes);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000020B4 File Offset: 0x000002B4
		public unsafe static void* UnsafeEncodeNativeArrayToJPG(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] int quality)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToJPGDelegateField(array, ref sizeInBytes, format, width, height, rowBytes, quality);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020CA File Offset: 0x000002CA
		public unsafe static void* UnsafeEncodeNativeArrayToEXR(void* array, ref int sizeInBytes, GraphicsFormat format, uint width, uint height, [Optional] uint rowBytes, [Optional] Texture2D.EXRFlags flags)
		{
			return ImageConversion.UnsafeEncodeNativeArrayToEXRDelegateField(array, ref sizeInBytes, format, width, height, rowBytes, flags);
		}

		// Token: 0x04000001 RID: 1
		private static readonly ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField = IL2CPP.ResolveICall<ImageConversion.GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate>("UnityEngine.ImageConversion::GetEnableLegacyPngGammaRuntimeLoadBehavior");

		// Token: 0x04000002 RID: 2
		private static readonly ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegateField = IL2CPP.ResolveICall<ImageConversion.SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate>("UnityEngine.ImageConversion::SetEnableLegacyPngGammaRuntimeLoadBehavior");

		// Token: 0x04000003 RID: 3
		private static readonly ImageConversion.EncodeToTGADelegate EncodeToTGADelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeToTGADelegate>("UnityEngine.ImageConversion::EncodeToTGA");

		// Token: 0x04000004 RID: 4
		private static readonly ImageConversion.EncodeToPNGDelegate EncodeToPNGDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeToPNGDelegate>("UnityEngine.ImageConversion::EncodeToPNG");

		// Token: 0x04000005 RID: 5
		private static readonly ImageConversion.EncodeToJPGDelegate EncodeToJPGDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeToJPGDelegate>("UnityEngine.ImageConversion::EncodeToJPG");

		// Token: 0x04000006 RID: 6
		private static readonly ImageConversion.EncodeToEXRDelegate EncodeToEXRDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeToEXRDelegate>("UnityEngine.ImageConversion::EncodeToEXR");

		// Token: 0x04000007 RID: 7
		private static readonly ImageConversion.LoadImageDelegate LoadImageDelegateField = IL2CPP.ResolveICall<ImageConversion.LoadImageDelegate>("UnityEngine.ImageConversion::LoadImage");

		// Token: 0x04000008 RID: 8
		private static readonly ImageConversion.EncodeArrayToTGADelegate EncodeArrayToTGADelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToTGADelegate>("UnityEngine.ImageConversion::EncodeArrayToTGA");

		// Token: 0x04000009 RID: 9
		private static readonly ImageConversion.EncodeArrayToPNGDelegate EncodeArrayToPNGDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToPNGDelegate>("UnityEngine.ImageConversion::EncodeArrayToPNG");

		// Token: 0x0400000A RID: 10
		private static readonly ImageConversion.EncodeArrayToJPGDelegate EncodeArrayToJPGDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToJPGDelegate>("UnityEngine.ImageConversion::EncodeArrayToJPG");

		// Token: 0x0400000B RID: 11
		private static readonly ImageConversion.EncodeArrayToEXRDelegate EncodeArrayToEXRDelegateField = IL2CPP.ResolveICall<ImageConversion.EncodeArrayToEXRDelegate>("UnityEngine.ImageConversion::EncodeArrayToEXR");

		// Token: 0x0400000C RID: 12
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToTGADelegate UnsafeEncodeNativeArrayToTGADelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToTGADelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToTGA");

		// Token: 0x0400000D RID: 13
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToPNGDelegate UnsafeEncodeNativeArrayToPNGDelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToPNGDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToPNG");

		// Token: 0x0400000E RID: 14
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToJPGDelegate UnsafeEncodeNativeArrayToJPGDelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToJPGDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToJPG");

		// Token: 0x0400000F RID: 15
		private static readonly ImageConversion.UnsafeEncodeNativeArrayToEXRDelegate UnsafeEncodeNativeArrayToEXRDelegateField = IL2CPP.ResolveICall<ImageConversion.UnsafeEncodeNativeArrayToEXRDelegate>("UnityEngine.ImageConversion::UnsafeEncodeNativeArrayToEXR");

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x0600001B RID: 27
		private delegate bool GetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate();

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600001D RID: 29
		private delegate void SetEnableLegacyPngGammaRuntimeLoadBehaviorDelegate(bool enable);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600001F RID: 31
		private delegate IntPtr EncodeToTGADelegate(IntPtr tex);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000021 RID: 33
		private delegate IntPtr EncodeToPNGDelegate(IntPtr tex);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x06000023 RID: 35
		private delegate IntPtr EncodeToJPGDelegate(IntPtr tex, int quality);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000025 RID: 37
		private delegate IntPtr EncodeToEXRDelegate(IntPtr tex, Texture2D.EXRFlags flags);

		// Token: 0x02000009 RID: 9
		// (Invoke) Token: 0x06000027 RID: 39
		private delegate bool LoadImageDelegate(IntPtr tex, IntPtr data, bool markNonReadable);

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000029 RID: 41
		private delegate IntPtr EncodeArrayToTGADelegate(IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600002B RID: 43
		private delegate IntPtr EncodeArrayToPNGDelegate(IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600002D RID: 45
		private delegate IntPtr EncodeArrayToJPGDelegate(IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes, int quality);

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x0600002F RID: 47
		private delegate IntPtr EncodeArrayToEXRDelegate(IntPtr array, GraphicsFormat format, uint width, uint height, uint rowBytes, Texture2D.EXRFlags flags);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate IntPtr UnsafeEncodeNativeArrayToTGADelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000033 RID: 51
		private delegate IntPtr UnsafeEncodeNativeArrayToPNGDelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate IntPtr UnsafeEncodeNativeArrayToJPGDelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes, int quality);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000037 RID: 55
		private delegate IntPtr UnsafeEncodeNativeArrayToEXRDelegate(IntPtr array, IntPtr sizeInBytes, GraphicsFormat format, uint width, uint height, uint rowBytes, Texture2D.EXRFlags flags);
	}
}
