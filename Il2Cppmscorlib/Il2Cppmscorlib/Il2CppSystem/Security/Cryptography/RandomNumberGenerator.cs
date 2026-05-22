using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002F5 RID: 757
	public class RandomNumberGenerator : Object
	{
		// Token: 0x0600326A RID: 12906 RVA: 0x000FC220 File Offset: 0x000FA420
		// Note: this type is marked as 'beforefieldinit'.
		static RandomNumberGenerator()
		{
			Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RandomNumberGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr);
			RandomNumberGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671249);
			RandomNumberGenerator.NativeMethodInfoPtr_Create_Public_Static_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671250);
			RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671251);
			RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671252);
			RandomNumberGenerator.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr, 100671253);
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x000FC2B4 File Offset: 0x000FA4B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomNumberGenerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomNumberGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomNumberGenerator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x000FC2F0 File Offset: 0x000FA4F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 210354, RefRangeEnd = 210368, XrefRangeStart = 210346, XrefRangeEnd = 210354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RandomNumberGenerator Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomNumberGenerator.NativeMethodInfoPtr_Create_Public_Static_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x000FC324 File Offset: 0x000FA524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210368, XrefRangeEnd = 210372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x000FC358 File Offset: 0x000FA558
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomNumberGenerator.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x000FC3A4 File Offset: 0x000FA5A4
		[CallerCount(0)]
		public unsafe virtual void GetBytes(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomNumberGenerator.NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x00011A8D File Offset: 0x0000FC8D
		public RandomNumberGenerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_RandomNumberGenerator_0;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_0;
	}
}
