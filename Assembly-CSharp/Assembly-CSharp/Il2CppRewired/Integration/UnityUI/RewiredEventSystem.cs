using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.EventSystems;

namespace Il2CppRewired.Integration.UnityUI
{
	// Token: 0x020001E9 RID: 489
	public class RewiredEventSystem : EventSystem
	{
		// Token: 0x06003931 RID: 14641 RVA: 0x000D55A4 File Offset: 0x000D37A4
		// Note: this type is marked as 'beforefieldinit'.
		static RewiredEventSystem()
		{
			Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", "RewiredEventSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr);
			RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, "_alwaysUpdate");
			RewiredEventSystem.NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668068);
			RewiredEventSystem.NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668069);
			RewiredEventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668070);
			RewiredEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668071);
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x000D5638 File Offset: 0x000D3838
		// (set) Token: 0x06003933 RID: 14643 RVA: 0x000D5674 File Offset: 0x000D3874
		public unsafe bool alwaysUpdate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x000D56B4 File Offset: 0x000D38B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88843, XrefRangeEnd = 88882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RewiredEventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x000D56F0 File Offset: 0x000D38F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88882, XrefRangeEnd = 88894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RewiredEventSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x000246B6 File Offset: 0x000228B6
		public RewiredEventSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x000D572C File Offset: 0x000D392C
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x000246BF File Offset: 0x000228BF
		public unsafe bool _alwaysUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate)) = value;
			}
		}

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeFieldInfoPtr__alwaysUpdate;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
