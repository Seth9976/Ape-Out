using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200017D RID: 381
	public class Scripter : MonoBehaviour
	{
		// Token: 0x06002D46 RID: 11590 RVA: 0x000B11BC File Offset: 0x000AF3BC
		// Note: this type is marked as 'beforefieldinit'.
		static Scripter()
		{
			Il2CppClassPointerStore<Scripter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Scripter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scripter>.NativeClassPtr);
			Scripter.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scripter>.NativeClassPtr, "nodes");
			Scripter.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scripter>.NativeClassPtr, 100666816);
			Scripter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scripter>.NativeClassPtr, 100666817);
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000B1228 File Offset: 0x000AF428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81109, XrefRangeEnd = 81112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scripter.NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000B125C File Offset: 0x000AF45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Scripter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scripter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Scripter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x0001F569 File Offset: 0x0001D769
		public Scripter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000B1298 File Offset: 0x000AF498
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x0001F572 File Offset: 0x0001D772
		public unsafe Il2CppReferenceArray<ScriptNode> nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scripter.NativeFieldInfoPtr_nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Scripter.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Public_Void_0;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
