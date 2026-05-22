using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000177 RID: 375
	public class RotateAwayFromPlayer : MonoBehaviour
	{
		// Token: 0x06002CF2 RID: 11506 RVA: 0x000B0288 File Offset: 0x000AE488
		// Note: this type is marked as 'beforefieldinit'.
		static RotateAwayFromPlayer()
		{
			Il2CppClassPointerStore<RotateAwayFromPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RotateAwayFromPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateAwayFromPlayer>.NativeClassPtr);
			RotateAwayFromPlayer.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateAwayFromPlayer>.NativeClassPtr, "pos");
			RotateAwayFromPlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAwayFromPlayer>.NativeClassPtr, 100666788);
			RotateAwayFromPlayer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAwayFromPlayer>.NativeClassPtr, 100666789);
			RotateAwayFromPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateAwayFromPlayer>.NativeClassPtr, 100666790);
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x000B0308 File Offset: 0x000AE508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80869, XrefRangeEnd = 80873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAwayFromPlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x000B033C File Offset: 0x000AE53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80873, XrefRangeEnd = 80882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAwayFromPlayer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000B0370 File Offset: 0x000AE570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateAwayFromPlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateAwayFromPlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateAwayFromPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x0001F2C5 File Offset: 0x0001D4C5
		public RotateAwayFromPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000B03AC File Offset: 0x000AE5AC
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x0001F2CE File Offset: 0x0001D4CE
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAwayFromPlayer.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateAwayFromPlayer.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
