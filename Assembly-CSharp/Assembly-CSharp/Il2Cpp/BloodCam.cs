using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000081 RID: 129
	public class BloodCam : MonoBehaviour
	{
		// Token: 0x0600107B RID: 4219 RVA: 0x0006412C File Offset: 0x0006232C
		// Note: this type is marked as 'beforefieldinit'.
		static BloodCam()
		{
			Il2CppClassPointerStore<BloodCam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BloodCam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloodCam>.NativeClassPtr);
			BloodCam.NativeFieldInfoPtr_passMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodCam>.NativeClassPtr, "passMat");
			BloodCam.NativeFieldInfoPtr_sliceNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodCam>.NativeClassPtr, "sliceNum");
			BloodCam.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloodCam>.NativeClassPtr, "rt");
			BloodCam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloodCam>.NativeClassPtr, 100664679);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x000641AC File Offset: 0x000623AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloodCam()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloodCam>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloodCam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0000C330 File Offset: 0x0000A530
		public BloodCam(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x0600107E RID: 4222 RVA: 0x000641E8 File Offset: 0x000623E8
		// (set) Token: 0x0600107F RID: 4223 RVA: 0x0000C339 File Offset: 0x0000A539
		public unsafe Material passMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodCam.NativeFieldInfoPtr_passMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodCam.NativeFieldInfoPtr_passMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00064218 File Offset: 0x00062418
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x0000C358 File Offset: 0x0000A558
		public unsafe int sliceNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodCam.NativeFieldInfoPtr_sliceNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodCam.NativeFieldInfoPtr_sliceNum)) = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00064240 File Offset: 0x00062440
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x0000C373 File Offset: 0x0000A573
		public unsafe RenderTexture rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodCam.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloodCam.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_passMat;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_sliceNum;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
