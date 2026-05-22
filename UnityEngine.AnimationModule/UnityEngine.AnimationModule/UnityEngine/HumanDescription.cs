using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	public sealed class HumanDescription : ValueType
	{
		// Token: 0x0600024E RID: 590 RVA: 0x00009CD0 File Offset: 0x00007ED0
		// Note: this type is marked as 'beforefieldinit'.
		static HumanDescription()
		{
			Il2CppClassPointerStore<HumanDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr);
			HumanDescription.NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "human");
			HumanDescription.NativeFieldInfoPtr_skeleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "skeleton");
			HumanDescription.NativeFieldInfoPtr_m_ArmTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_ArmTwist");
			HumanDescription.NativeFieldInfoPtr_m_ForeArmTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_ForeArmTwist");
			HumanDescription.NativeFieldInfoPtr_m_UpperLegTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_UpperLegTwist");
			HumanDescription.NativeFieldInfoPtr_m_LegTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_LegTwist");
			HumanDescription.NativeFieldInfoPtr_m_ArmStretch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_ArmStretch");
			HumanDescription.NativeFieldInfoPtr_m_LegStretch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_LegStretch");
			HumanDescription.NativeFieldInfoPtr_m_FeetSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_FeetSpacing");
			HumanDescription.NativeFieldInfoPtr_m_GlobalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_GlobalScale");
			HumanDescription.NativeFieldInfoPtr_m_RootMotionBoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_RootMotionBoneName");
			HumanDescription.NativeFieldInfoPtr_m_HasTranslationDoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_HasTranslationDoF");
			HumanDescription.NativeFieldInfoPtr_m_HasExtraRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_HasExtraRoot");
			HumanDescription.NativeFieldInfoPtr_m_SkeletonHasParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_SkeletonHasParents");
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000037B1 File Offset: 0x000019B1
		public HumanDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000037BA File Offset: 0x000019BA
		public HumanDescription()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr))
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00009E18 File Offset: 0x00008018
		// (set) Token: 0x06000252 RID: 594 RVA: 0x000037CC File Offset: 0x000019CC
		public unsafe Il2CppReferenceArray<HumanBone> human
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_human);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HumanBone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_human), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00009E48 File Offset: 0x00008048
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000037EB File Offset: 0x000019EB
		public unsafe Il2CppReferenceArray<SkeletonBone> skeleton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_skeleton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkeletonBone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_skeleton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00009E78 File Offset: 0x00008078
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000380A File Offset: 0x00001A0A
		public unsafe float m_ArmTwist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_ArmTwist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_ArmTwist)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00009EA0 File Offset: 0x000080A0
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00003825 File Offset: 0x00001A25
		public unsafe float m_ForeArmTwist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_ForeArmTwist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_ForeArmTwist)) = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00009EC8 File Offset: 0x000080C8
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00003840 File Offset: 0x00001A40
		public unsafe float m_UpperLegTwist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_UpperLegTwist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_UpperLegTwist)) = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00009EF0 File Offset: 0x000080F0
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000385B File Offset: 0x00001A5B
		public unsafe float m_LegTwist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_LegTwist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_LegTwist)) = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00009F18 File Offset: 0x00008118
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00003876 File Offset: 0x00001A76
		public unsafe float m_ArmStretch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_ArmStretch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_ArmStretch)) = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00009F40 File Offset: 0x00008140
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00003891 File Offset: 0x00001A91
		public unsafe float m_LegStretch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_LegStretch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_LegStretch)) = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00009F68 File Offset: 0x00008168
		// (set) Token: 0x06000262 RID: 610 RVA: 0x000038AC File Offset: 0x00001AAC
		public unsafe float m_FeetSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_FeetSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_FeetSpacing)) = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00009F90 File Offset: 0x00008190
		// (set) Token: 0x06000264 RID: 612 RVA: 0x000038C7 File Offset: 0x00001AC7
		public unsafe float m_GlobalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_GlobalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_GlobalScale)) = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00009FB8 File Offset: 0x000081B8
		// (set) Token: 0x06000266 RID: 614 RVA: 0x000038E2 File Offset: 0x00001AE2
		public unsafe string m_RootMotionBoneName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_RootMotionBoneName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_RootMotionBoneName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00009FE0 File Offset: 0x000081E0
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00003901 File Offset: 0x00001B01
		public unsafe bool m_HasTranslationDoF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_HasTranslationDoF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_HasTranslationDoF)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0000A008 File Offset: 0x00008208
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0000391C File Offset: 0x00001B1C
		public unsafe bool m_HasExtraRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_HasExtraRoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_HasExtraRoot)) = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0000A030 File Offset: 0x00008230
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00003937 File Offset: 0x00001B37
		public unsafe bool m_SkeletonHasParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_SkeletonHasParents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HumanDescription.NativeFieldInfoPtr_m_SkeletonHasParents)) = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000A058 File Offset: 0x00008258
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00003952 File Offset: 0x00001B52
		public float upperArmTwist
		{
			get
			{
				return this.m_ArmTwist;
			}
			set
			{
				this.m_ArmTwist = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000A070 File Offset: 0x00008270
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000395C File Offset: 0x00001B5C
		public float lowerArmTwist
		{
			get
			{
				return this.m_ForeArmTwist;
			}
			set
			{
				this.m_ForeArmTwist = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000A088 File Offset: 0x00008288
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00003966 File Offset: 0x00001B66
		public float upperLegTwist
		{
			get
			{
				return this.m_UpperLegTwist;
			}
			set
			{
				this.m_UpperLegTwist = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000A0A0 File Offset: 0x000082A0
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00003970 File Offset: 0x00001B70
		public float lowerLegTwist
		{
			get
			{
				return this.m_LegTwist;
			}
			set
			{
				this.m_LegTwist = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0000A0B8 File Offset: 0x000082B8
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0000397A File Offset: 0x00001B7A
		public float armStretch
		{
			get
			{
				return this.m_ArmStretch;
			}
			set
			{
				this.m_ArmStretch = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000A0D0 File Offset: 0x000082D0
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003984 File Offset: 0x00001B84
		public float legStretch
		{
			get
			{
				return this.m_LegStretch;
			}
			set
			{
				this.m_LegStretch = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0000A0E8 File Offset: 0x000082E8
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000398E File Offset: 0x00001B8E
		public float feetSpacing
		{
			get
			{
				return this.m_FeetSpacing;
			}
			set
			{
				this.m_FeetSpacing = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000A100 File Offset: 0x00008300
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00003998 File Offset: 0x00001B98
		public bool hasTranslationDoF
		{
			get
			{
				return this.m_HasTranslationDoF;
			}
			set
			{
				this.m_HasTranslationDoF = value;
			}
		}

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_human;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_skeleton;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_m_ArmTwist;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_m_ForeArmTwist;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_m_UpperLegTwist;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_m_LegTwist;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_m_ArmStretch;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_m_LegStretch;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_m_FeetSpacing;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_m_GlobalScale;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_m_RootMotionBoneName;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_m_HasTranslationDoF;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_m_HasExtraRoot;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_m_SkeletonHasParents;
	}
}
