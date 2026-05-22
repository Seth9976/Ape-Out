using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000DD RID: 221
	public class Flash : MonoBehaviour
	{
		// Token: 0x06001954 RID: 6484 RVA: 0x0007B7D0 File Offset: 0x000799D0
		// Note: this type is marked as 'beforefieldinit'.
		static Flash()
		{
			Il2CppClassPointerStore<Flash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Flash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flash>.NativeClassPtr);
			Flash.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Flash>.NativeClassPtr, "counter");
			Flash.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100665377);
			Flash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flash>.NativeClassPtr, 100665378);
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0007B83C File Offset: 0x00079A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58850, XrefRangeEnd = 58856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0007B870 File Offset: 0x00079A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flash()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000120EE File Offset: 0x000102EE
		public Flash(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x0007B8AC File Offset: 0x00079AAC
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x000120F7 File Offset: 0x000102F7
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flash.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Flash.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x04000F12 RID: 3858
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
