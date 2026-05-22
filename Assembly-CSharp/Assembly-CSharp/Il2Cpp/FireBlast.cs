using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020000D2 RID: 210
	public class FireBlast : MonoBehaviour
	{
		// Token: 0x060018CD RID: 6349 RVA: 0x00079F64 File Offset: 0x00078164
		// Note: this type is marked as 'beforefieldinit'.
		static FireBlast()
		{
			Il2CppClassPointerStore<FireBlast>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FireBlast");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FireBlast>.NativeClassPtr);
			FireBlast.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FireBlast>.NativeClassPtr, "timer");
			FireBlast.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireBlast>.NativeClassPtr, 100665334);
			FireBlast.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FireBlast>.NativeClassPtr, 100665335);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00079FD0 File Offset: 0x000781D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58180, XrefRangeEnd = 58224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireBlast.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0007A004 File Offset: 0x00078204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FireBlast()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FireBlast>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FireBlast.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x00011C62 File Offset: 0x0000FE62
		public FireBlast(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0007A040 File Offset: 0x00078240
		// (set) Token: 0x060018D2 RID: 6354 RVA: 0x00011C6B File Offset: 0x0000FE6B
		public unsafe int timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireBlast.NativeFieldInfoPtr_timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FireBlast.NativeFieldInfoPtr_timer)) = value;
			}
		}

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
