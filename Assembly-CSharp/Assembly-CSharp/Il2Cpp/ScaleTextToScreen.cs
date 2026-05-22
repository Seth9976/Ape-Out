using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200017A RID: 378
	public class ScaleTextToScreen : MonoBehaviour
	{
		// Token: 0x06002D29 RID: 11561 RVA: 0x000B0CBC File Offset: 0x000AEEBC
		// Note: this type is marked as 'beforefieldinit'.
		static ScaleTextToScreen()
		{
			Il2CppClassPointerStore<ScaleTextToScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ScaleTextToScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleTextToScreen>.NativeClassPtr);
			ScaleTextToScreen.NativeFieldInfoPtr_rend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleTextToScreen>.NativeClassPtr, "rend");
			ScaleTextToScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleTextToScreen>.NativeClassPtr, 100666807);
			ScaleTextToScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleTextToScreen>.NativeClassPtr, 100666808);
			ScaleTextToScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleTextToScreen>.NativeClassPtr, 100666809);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000B0D3C File Offset: 0x000AEF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81062, XrefRangeEnd = 81065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleTextToScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000B0D70 File Offset: 0x000AEF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81065, XrefRangeEnd = 81082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleTextToScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000B0DA4 File Offset: 0x000AEFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleTextToScreen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleTextToScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleTextToScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x0001F489 File Offset: 0x0001D689
		public ScaleTextToScreen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x000B0DE0 File Offset: 0x000AEFE0
		// (set) Token: 0x06002D2F RID: 11567 RVA: 0x0001F492 File Offset: 0x0001D692
		public unsafe MeshRenderer rend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleTextToScreen.NativeFieldInfoPtr_rend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleTextToScreen.NativeFieldInfoPtr_rend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeFieldInfoPtr_rend;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
