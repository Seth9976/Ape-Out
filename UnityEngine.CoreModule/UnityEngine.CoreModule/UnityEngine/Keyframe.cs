using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000044 RID: 68
	[StructLayout(2)]
	public struct Keyframe
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0001966C File Offset: 0x0001786C
		// Note: this type is marked as 'beforefieldinit'.
		static Keyframe()
		{
			Il2CppClassPointerStore<Keyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Keyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyframe>.NativeClassPtr);
			Keyframe.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Time");
			Keyframe.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_Value");
			Keyframe.NativeFieldInfoPtr_m_InTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InTangent");
			Keyframe.NativeFieldInfoPtr_m_OutTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutTangent");
			Keyframe.NativeFieldInfoPtr_m_WeightedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_WeightedMode");
			Keyframe.NativeFieldInfoPtr_m_InWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_InWeight");
			Keyframe.NativeFieldInfoPtr_m_OutWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, "m_OutWeight");
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663415);
			Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663416);
			Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663417);
			Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663418);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00019778 File Offset: 0x00017978
		[CallerCount(0)]
		public unsafe Keyframe(float time, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000197B8 File Offset: 0x000179B8
		[CallerCount(0)]
		public unsafe Keyframe(float time, float value, float inTangent, float outTangent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inTangent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outTangent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00019814 File Offset: 0x00017A14
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00019844 File Offset: 0x00017A44
		public unsafe float time
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 485970, RefRangeEnd = 485974, XrefRangeStart = 485970, XrefRangeEnd = 485970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00003216 File Offset: 0x00001416
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, ref this));
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00019878 File Offset: 0x00017A78
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00003228 File Offset: 0x00001428
		public float value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00019890 File Offset: 0x00017A90
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00003232 File Offset: 0x00001432
		public float inTangent
		{
			get
			{
				return this.m_InTangent;
			}
			set
			{
				this.m_InTangent = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000198A8 File Offset: 0x00017AA8
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000323C File Offset: 0x0000143C
		public float outTangent
		{
			get
			{
				return this.m_OutTangent;
			}
			set
			{
				this.m_OutTangent = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000198C0 File Offset: 0x00017AC0
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00003246 File Offset: 0x00001446
		public float inWeight
		{
			get
			{
				return this.m_InWeight;
			}
			set
			{
				this.m_InWeight = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000198D8 File Offset: 0x00017AD8
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00003250 File Offset: 0x00001450
		public float outWeight
		{
			get
			{
				return this.m_OutWeight;
			}
			set
			{
				this.m_OutWeight = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000198F0 File Offset: 0x00017AF0
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000325A File Offset: 0x0000145A
		public WeightedMode weightedMode
		{
			get
			{
				return (WeightedMode)this.m_WeightedMode;
			}
			set
			{
				this.m_WeightedMode = (int)value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00019908 File Offset: 0x00017B08
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00003264 File Offset: 0x00001464
		public int tangentMode
		{
			get
			{
				return this.tangentModeInternal;
			}
			set
			{
				this.tangentModeInternal = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00019920 File Offset: 0x00017B20
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000326F File Offset: 0x0000146F
		public int tangentModeInternal
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_m_Time;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_InTangent;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_m_OutTangent;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_m_WeightedMode;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_m_InWeight;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_m_OutWeight;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x0400019A RID: 410
		[FieldOffset(0)]
		public float m_Time;

		// Token: 0x0400019B RID: 411
		[FieldOffset(4)]
		public float m_Value;

		// Token: 0x0400019C RID: 412
		[FieldOffset(8)]
		public float m_InTangent;

		// Token: 0x0400019D RID: 413
		[FieldOffset(12)]
		public float m_OutTangent;

		// Token: 0x0400019E RID: 414
		[FieldOffset(16)]
		public int m_WeightedMode;

		// Token: 0x0400019F RID: 415
		[FieldOffset(20)]
		public float m_InWeight;

		// Token: 0x040001A0 RID: 416
		[FieldOffset(24)]
		public float m_OutWeight;
	}
}
