using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000120 RID: 288
	[Serializable]
	public class GamArr : global::Il2CppSystem.Object
	{
		// Token: 0x060022A4 RID: 8868 RVA: 0x00094818 File Offset: 0x00092A18
		// Note: this type is marked as 'beforefieldinit'.
		static GamArr()
		{
			Il2CppClassPointerStore<GamArr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "GamArr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamArr>.NativeClassPtr);
			GamArr.NativeFieldInfoPtr_arr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamArr>.NativeClassPtr, "arr");
			GamArr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamArr>.NativeClassPtr, 100665991);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00094870 File Offset: 0x00092A70
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GamArr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GamArr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GamArr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000184EB File Offset: 0x000166EB
		public GamArr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x000948AC File Offset: 0x00092AAC
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x000184F4 File Offset: 0x000166F4
		public unsafe Il2CppReferenceArray<GameObject> arr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamArr.NativeFieldInfoPtr_arr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GamArr.NativeFieldInfoPtr_arr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeFieldInfoPtr_arr;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
