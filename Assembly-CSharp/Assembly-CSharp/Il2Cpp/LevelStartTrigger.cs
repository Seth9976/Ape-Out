using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200011E RID: 286
	public class LevelStartTrigger : MonoBehaviour
	{
		// Token: 0x0600228A RID: 8842 RVA: 0x00094328 File Offset: 0x00092528
		// Note: this type is marked as 'beforefieldinit'.
		static LevelStartTrigger()
		{
			Il2CppClassPointerStore<LevelStartTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LevelStartTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelStartTrigger>.NativeClassPtr);
			LevelStartTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelStartTrigger>.NativeClassPtr, 100665969);
			LevelStartTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelStartTrigger>.NativeClassPtr, 100665970);
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00094380 File Offset: 0x00092580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69372, XrefRangeEnd = 69377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelStartTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x000943C4 File Offset: 0x000925C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelStartTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelStartTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelStartTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600228D RID: 8845 RVA: 0x00018433 File Offset: 0x00016633
		public LevelStartTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
