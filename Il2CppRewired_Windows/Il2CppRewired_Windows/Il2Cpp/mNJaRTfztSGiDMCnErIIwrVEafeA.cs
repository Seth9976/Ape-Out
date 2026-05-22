using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200006C RID: 108
	public class mNJaRTfztSGiDMCnErIIwrVEafeA : EventArgs
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x0002A67C File Offset: 0x0002887C
		// Note: this type is marked as 'beforefieldinit'.
		static mNJaRTfztSGiDMCnErIIwrVEafeA()
		{
			Il2CppClassPointerStore<mNJaRTfztSGiDMCnErIIwrVEafeA>.NativeClassPtr = IL2CPP.GetIl2CppClass("Rewired_Windows.dll", "", "mNJaRTfztSGiDMCnErIIwrVEafeA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<mNJaRTfztSGiDMCnErIIwrVEafeA>.NativeClassPtr);
			mNJaRTfztSGiDMCnErIIwrVEafeA.NativeFieldInfoPtr_UajRXrikVdrJYwBHFEMjtBfUoQW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<mNJaRTfztSGiDMCnErIIwrVEafeA>.NativeClassPtr, "UajRXrikVdrJYwBHFEMjtBfUoQW");
			mNJaRTfztSGiDMCnErIIwrVEafeA.NativeMethodInfoPtr__ctor_Public_Void_lTYDyFJBhzGCRcmOcRRJrzdwCPST_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<mNJaRTfztSGiDMCnErIIwrVEafeA>.NativeClassPtr, 100664815);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0002A6D4 File Offset: 0x000288D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 359308, RefRangeEnd = 359311, XrefRangeStart = 359305, XrefRangeEnd = 359308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe mNJaRTfztSGiDMCnErIIwrVEafeA(lTYDyFJBhzGCRcmOcRRJrzdwCPST o)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<mNJaRTfztSGiDMCnErIIwrVEafeA>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(mNJaRTfztSGiDMCnErIIwrVEafeA.NativeMethodInfoPtr__ctor_Public_Void_lTYDyFJBhzGCRcmOcRRJrzdwCPST_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00005E57 File Offset: 0x00004057
		public mNJaRTfztSGiDMCnErIIwrVEafeA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0002A720 File Offset: 0x00028920
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00005E60 File Offset: 0x00004060
		public unsafe lTYDyFJBhzGCRcmOcRRJrzdwCPST UajRXrikVdrJYwBHFEMjtBfUoQW
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(mNJaRTfztSGiDMCnErIIwrVEafeA.NativeFieldInfoPtr_UajRXrikVdrJYwBHFEMjtBfUoQW);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<lTYDyFJBhzGCRcmOcRRJrzdwCPST>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(mNJaRTfztSGiDMCnErIIwrVEafeA.NativeFieldInfoPtr_UajRXrikVdrJYwBHFEMjtBfUoQW), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_UajRXrikVdrJYwBHFEMjtBfUoQW;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_lTYDyFJBhzGCRcmOcRRJrzdwCPST_0;
	}
}
