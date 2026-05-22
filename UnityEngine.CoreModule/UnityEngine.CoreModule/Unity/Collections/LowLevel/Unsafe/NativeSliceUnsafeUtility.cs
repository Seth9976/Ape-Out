using System;
using Il2CppSystem;

namespace Unity.Collections.LowLevel.Unsafe
{
	// Token: 0x020001D2 RID: 466
	public static class NativeSliceUnsafeUtility
	{
		// Token: 0x06002005 RID: 8197 RVA: 0x00074154 File Offset: 0x00072354
		public unsafe static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) where T : struct
		{
			bool flag = length < 0;
			if (flag)
			{
				throw new ArgumentException(String.Format("Invalid length of '{0}'. It must be greater than 0.", length), "length");
			}
			bool flag2 = stride < 0;
			if (flag2)
			{
				throw new ArgumentException(String.Format("Invalid stride '{0}'. It must be greater than 0.", stride), "stride");
			}
			NativeSlice<T> nativeSlice = null;
			nativeSlice.m_Stride = stride;
			nativeSlice.m_Buffer = (byte*)dataPointer;
			nativeSlice.m_Length = length;
			return nativeSlice;
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x000741D4 File Offset: 0x000723D4
		public unsafe static void* GetUnsafePtr<T>(NativeSlice<T> nativeSlice) where T : struct
		{
			return (void*)nativeSlice.m_Buffer;
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x000741EC File Offset: 0x000723EC
		public unsafe static void* GetUnsafeReadOnlyPtr<T>(NativeSlice<T> nativeSlice) where T : struct
		{
			return (void*)nativeSlice.m_Buffer;
		}
	}
}
