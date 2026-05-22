using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Networking
{
	// Token: 0x0200000B RID: 11
	public sealed class UploadHandlerRaw : UploadHandler
	{
		// Token: 0x06000126 RID: 294 RVA: 0x000062E4 File Offset: 0x000044E4
		// Note: this type is marked as 'beforefieldinit'.
		static UploadHandlerRaw()
		{
			Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UploadHandlerRaw");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr);
			UploadHandlerRaw.NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663390);
			UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr, 100663391);
			UploadHandlerRaw.InternalGetDataDelegateField = IL2CPP.ResolveICall<UploadHandlerRaw.InternalGetDataDelegate>("UnityEngine.Networking.UploadHandlerRaw::InternalGetData");
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000634C File Offset: 0x0000454C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534891, XrefRangeEnd = 534895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Create(UploadHandlerRaw self, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000063A0 File Offset: 0x000045A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 534895, XrefRangeEnd = 534897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandlerRaw(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandlerRaw>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandlerRaw.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000025B1 File Offset: 0x000007B1
		public UploadHandlerRaw(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000063EC File Offset: 0x000045EC
		public Il2CppStructArray<byte> InternalGetData()
		{
			IntPtr intPtr = UploadHandlerRaw.InternalGetDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006418 File Offset: 0x00004618
		public override Il2CppStructArray<byte> GetData()
		{
			return this.InternalGetData();
		}

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_UploadHandlerRaw_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400009E RID: 158
		private static readonly UploadHandlerRaw.InternalGetDataDelegate InternalGetDataDelegateField;

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000180 RID: 384
		private delegate IntPtr InternalGetDataDelegate(IntPtr @this);
	}
}
