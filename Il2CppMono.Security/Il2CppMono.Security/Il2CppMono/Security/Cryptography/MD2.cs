using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x0200002A RID: 42
	public class MD2 : HashAlgorithm
	{
		// Token: 0x0600021C RID: 540 RVA: 0x0000B760 File Offset: 0x00009960
		// Note: this type is marked as 'beforefieldinit'.
		static MD2()
		{
			Il2CppClassPointerStore<MD2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "MD2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MD2>.NativeClassPtr);
			MD2.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663579);
			MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MD2>.NativeClassPtr, 100663580);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000B7B8 File Offset: 0x000099B8
		[CallerCount(0)]
		public unsafe MD2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MD2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B7F4 File Offset: 0x000099F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129770, XrefRangeEnd = 129774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MD2 Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MD2.NativeMethodInfoPtr_Create_Public_Static_MD2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MD2>(intPtr3) : null;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002EB0 File Offset: 0x000010B0
		public MD2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_MD2_0;
	}
}
