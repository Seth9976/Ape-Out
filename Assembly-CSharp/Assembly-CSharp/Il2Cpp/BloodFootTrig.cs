using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000082 RID: 130
	public class BloodFootTrig : MonoBehaviour
	{
		// Token: 0x06001084 RID: 4228 RVA: 0x00064270 File Offset: 0x00062470
		// Note: this type is marked as 'beforefieldinit'.
		static BloodFootTrig()
		{
			Il2CppClassPointerStore<BloodFootTrig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BloodFootTrig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodFootTrig>.NativeClassPtr);
			BloodFootTrig.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFootTrig>.NativeClassPtr, 100664680);
			BloodFootTrig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodFootTrig>.NativeClassPtr, 100664681);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x000642C8 File Offset: 0x000624C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48223, XrefRangeEnd = 48226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloodFootTrig.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0006430C File Offset: 0x0006250C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloodFootTrig()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodFootTrig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloodFootTrig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0000C392 File Offset: 0x0000A592
		public BloodFootTrig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
