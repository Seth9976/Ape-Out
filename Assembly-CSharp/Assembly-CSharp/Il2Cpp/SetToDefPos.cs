using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000181 RID: 385
	public class SetToDefPos : MonoBehaviour
	{
		// Token: 0x06002DCA RID: 11722 RVA: 0x000B27A0 File Offset: 0x000B09A0
		// Note: this type is marked as 'beforefieldinit'.
		static SetToDefPos()
		{
			Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SetToDefPos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr);
			SetToDefPos.NativeFieldInfoPtr_mang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr, "mang");
			SetToDefPos.NativeFieldInfoPtr_offSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr, "offSet");
			SetToDefPos.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr, 100666876);
			SetToDefPos.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr, 100666877);
			SetToDefPos.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr, 100666878);
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x000B2834 File Offset: 0x000B0A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81388, XrefRangeEnd = 81402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetToDefPos.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000B2868 File Offset: 0x000B0A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81402, XrefRangeEnd = 81406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetToDefPos.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x000B289C File Offset: 0x000B0A9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetToDefPos()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetToDefPos>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetToDefPos.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x0001FAAE File Offset: 0x0001DCAE
		public SetToDefPos(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x000B28D8 File Offset: 0x000B0AD8
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x0001FAB7 File Offset: 0x0001DCB7
		public unsafe OfficeViewManager mang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetToDefPos.NativeFieldInfoPtr_mang);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfficeViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetToDefPos.NativeFieldInfoPtr_mang), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000B2908 File Offset: 0x000B0B08
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x0001FAD6 File Offset: 0x0001DCD6
		public unsafe Vector2 offSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetToDefPos.NativeFieldInfoPtr_offSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetToDefPos.NativeFieldInfoPtr_offSet)) = value;
			}
		}

		// Token: 0x04001AF3 RID: 6899
		private static readonly IntPtr NativeFieldInfoPtr_mang;

		// Token: 0x04001AF4 RID: 6900
		private static readonly IntPtr NativeFieldInfoPtr_offSet;

		// Token: 0x04001AF5 RID: 6901
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001AF6 RID: 6902
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001AF7 RID: 6903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
