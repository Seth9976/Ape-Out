using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200009A RID: 154
	public class Cable : MonoBehaviour
	{
		// Token: 0x0600125E RID: 4702 RVA: 0x00068E18 File Offset: 0x00067018
		// Note: this type is marked as 'beforefieldinit'.
		static Cable()
		{
			Il2CppClassPointerStore<Cable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Cable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cable>.NativeClassPtr);
			Cable.NativeFieldInfoPtr_desDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "desDist");
			Cable.NativeFieldInfoPtr_dad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "dad");
			Cable.NativeFieldInfoPtr_vel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "vel");
			Cable.NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "drag");
			Cable.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "offset");
			Cable.NativeFieldInfoPtr_maxAng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "maxAng");
			Cable.NativeFieldInfoPtr_maxCorrection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "maxCorrection");
			Cable.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cable>.NativeClassPtr, "pos");
			Cable.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cable>.NativeClassPtr, 100664860);
			Cable.NativeMethodInfoPtr_PoodleUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cable>.NativeClassPtr, 100664861);
			Cable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cable>.NativeClassPtr, 100664862);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00068F24 File Offset: 0x00067124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 49963, RefRangeEnd = 49964, XrefRangeStart = 49953, XrefRangeEnd = 49963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cable.NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00068F60 File Offset: 0x00067160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50015, RefRangeEnd = 50016, XrefRangeStart = 49964, XrefRangeEnd = 50015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PoodleUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cable.NativeMethodInfoPtr_PoodleUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00068F94 File Offset: 0x00067194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cable()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0000D74E File Offset: 0x0000B94E
		public Cable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00068FD0 File Offset: 0x000671D0
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x0000D757 File Offset: 0x0000B957
		public unsafe float desDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_desDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_desDist)) = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00068FF8 File Offset: 0x000671F8
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x0000D772 File Offset: 0x0000B972
		public unsafe Transform dad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_dad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_dad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00069028 File Offset: 0x00067228
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x0000D791 File Offset: 0x0000B991
		public unsafe Vector2 vel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_vel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_vel)) = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00069050 File Offset: 0x00067250
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		public unsafe float drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_drag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_drag)) = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00069078 File Offset: 0x00067278
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x0000D7C7 File Offset: 0x0000B9C7
		public unsafe Vector2 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x000690A0 File Offset: 0x000672A0
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x0000D7E2 File Offset: 0x0000B9E2
		public unsafe float maxAng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_maxAng);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_maxAng)) = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x000690C8 File Offset: 0x000672C8
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0000D7FD File Offset: 0x0000B9FD
		public unsafe float maxCorrection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_maxCorrection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_maxCorrection)) = value;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x000690F0 File Offset: 0x000672F0
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x0000D818 File Offset: 0x0000BA18
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cable.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x04000B0C RID: 2828
		private static readonly IntPtr NativeFieldInfoPtr_desDist;

		// Token: 0x04000B0D RID: 2829
		private static readonly IntPtr NativeFieldInfoPtr_dad;

		// Token: 0x04000B0E RID: 2830
		private static readonly IntPtr NativeFieldInfoPtr_vel;

		// Token: 0x04000B0F RID: 2831
		private static readonly IntPtr NativeFieldInfoPtr_drag;

		// Token: 0x04000B10 RID: 2832
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04000B11 RID: 2833
		private static readonly IntPtr NativeFieldInfoPtr_maxAng;

		// Token: 0x04000B12 RID: 2834
		private static readonly IntPtr NativeFieldInfoPtr_maxCorrection;

		// Token: 0x04000B13 RID: 2835
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x04000B14 RID: 2836
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_New_Void_0;

		// Token: 0x04000B15 RID: 2837
		private static readonly IntPtr NativeMethodInfoPtr_PoodleUpdate_Public_Void_0;

		// Token: 0x04000B16 RID: 2838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
