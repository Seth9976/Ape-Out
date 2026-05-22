using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000049 RID: 73
	public class HumanTrait
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00004C8B File Offset: 0x00002E8B
		public static int MuscleCount
		{
			get
			{
				return HumanTrait.get_MuscleCountDelegateField();
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00004C97 File Offset: 0x00002E97
		public static int GetBoneIndexFromMono(int humanId)
		{
			return HumanTrait.GetBoneIndexFromMonoDelegateField(humanId);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00004CA4 File Offset: 0x00002EA4
		public static int GetBoneIndexToMono(int boneIndex)
		{
			return HumanTrait.GetBoneIndexToMonoDelegateField(boneIndex);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		public static Il2CppStringArray MuscleName
		{
			get
			{
				IntPtr intPtr = HumanTrait.get_MuscleNameDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x00004CB1 File Offset: 0x00002EB1
		public static int BoneCount
		{
			get
			{
				return HumanTrait.get_BoneCountDelegateField();
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000E4F8 File Offset: 0x0000C6F8
		public static Il2CppStringArray BoneName
		{
			get
			{
				IntPtr intPtr = HumanTrait.get_BoneNameDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000E520 File Offset: 0x0000C720
		public static int MuscleFromBone(int i, int dofIndex)
		{
			return HumanTrait.Internal_MuscleFromBone(HumanTrait.GetBoneIndexFromMono(i), dofIndex);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00004CBD File Offset: 0x00002EBD
		public static int Internal_MuscleFromBone(int i, int dofIndex)
		{
			return HumanTrait.Internal_MuscleFromBoneDelegateField(i, dofIndex);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000E540 File Offset: 0x0000C740
		public static int BoneFromMuscle(int i)
		{
			return HumanTrait.GetBoneIndexToMono(HumanTrait.Internal_BoneFromMuscle(i));
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00004CCB File Offset: 0x00002ECB
		public static int Internal_BoneFromMuscle(int i)
		{
			return HumanTrait.Internal_BoneFromMuscleDelegateField(i);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000E560 File Offset: 0x0000C760
		public static bool RequiredBone(int i)
		{
			return HumanTrait.Internal_RequiredBone(HumanTrait.GetBoneIndexFromMono(i));
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public static bool Internal_RequiredBone(int i)
		{
			return HumanTrait.Internal_RequiredBoneDelegateField(i);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00004CE5 File Offset: 0x00002EE5
		public static int RequiredBoneCount
		{
			get
			{
				return HumanTrait.get_RequiredBoneCountDelegateField();
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00004CF1 File Offset: 0x00002EF1
		public static float GetMuscleDefaultMin(int i)
		{
			return HumanTrait.GetMuscleDefaultMinDelegateField(i);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004CFE File Offset: 0x00002EFE
		public static float GetMuscleDefaultMax(int i)
		{
			return HumanTrait.GetMuscleDefaultMaxDelegateField(i);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000E580 File Offset: 0x0000C780
		public static float GetBoneDefaultHierarchyMass(int i)
		{
			return HumanTrait.Internal_GetBoneHierarchyMass(HumanTrait.GetBoneIndexFromMono(i));
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		public static int GetParentBone(int i)
		{
			int num = HumanTrait.Internal_GetParent(HumanTrait.GetBoneIndexFromMono(i));
			return (num != -1) ? HumanTrait.GetBoneIndexToMono(num) : (-1);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00004D0B File Offset: 0x00002F0B
		public static float Internal_GetBoneHierarchyMass(int i)
		{
			return HumanTrait.Internal_GetBoneHierarchyMassDelegateField(i);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00004D18 File Offset: 0x00002F18
		public static int Internal_GetParent(int i)
		{
			return HumanTrait.Internal_GetParentDelegateField(i);
		}

		// Token: 0x04000383 RID: 899
		private static readonly HumanTrait.get_MuscleCountDelegate get_MuscleCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_MuscleCountDelegate>("UnityEngine.HumanTrait::get_MuscleCount");

		// Token: 0x04000384 RID: 900
		private static readonly HumanTrait.GetBoneIndexFromMonoDelegate GetBoneIndexFromMonoDelegateField = IL2CPP.ResolveICall<HumanTrait.GetBoneIndexFromMonoDelegate>("UnityEngine.HumanTrait::GetBoneIndexFromMono");

		// Token: 0x04000385 RID: 901
		private static readonly HumanTrait.GetBoneIndexToMonoDelegate GetBoneIndexToMonoDelegateField = IL2CPP.ResolveICall<HumanTrait.GetBoneIndexToMonoDelegate>("UnityEngine.HumanTrait::GetBoneIndexToMono");

		// Token: 0x04000386 RID: 902
		private static readonly HumanTrait.get_MuscleNameDelegate get_MuscleNameDelegateField = IL2CPP.ResolveICall<HumanTrait.get_MuscleNameDelegate>("UnityEngine.HumanTrait::get_MuscleName");

		// Token: 0x04000387 RID: 903
		private static readonly HumanTrait.get_BoneCountDelegate get_BoneCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_BoneCountDelegate>("UnityEngine.HumanTrait::get_BoneCount");

		// Token: 0x04000388 RID: 904
		private static readonly HumanTrait.get_BoneNameDelegate get_BoneNameDelegateField = IL2CPP.ResolveICall<HumanTrait.get_BoneNameDelegate>("UnityEngine.HumanTrait::get_BoneName");

		// Token: 0x04000389 RID: 905
		private static readonly HumanTrait.Internal_MuscleFromBoneDelegate Internal_MuscleFromBoneDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_MuscleFromBoneDelegate>("UnityEngine.HumanTrait::Internal_MuscleFromBone");

		// Token: 0x0400038A RID: 906
		private static readonly HumanTrait.Internal_BoneFromMuscleDelegate Internal_BoneFromMuscleDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_BoneFromMuscleDelegate>("UnityEngine.HumanTrait::Internal_BoneFromMuscle");

		// Token: 0x0400038B RID: 907
		private static readonly HumanTrait.Internal_RequiredBoneDelegate Internal_RequiredBoneDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_RequiredBoneDelegate>("UnityEngine.HumanTrait::Internal_RequiredBone");

		// Token: 0x0400038C RID: 908
		private static readonly HumanTrait.get_RequiredBoneCountDelegate get_RequiredBoneCountDelegateField = IL2CPP.ResolveICall<HumanTrait.get_RequiredBoneCountDelegate>("UnityEngine.HumanTrait::get_RequiredBoneCount");

		// Token: 0x0400038D RID: 909
		private static readonly HumanTrait.GetMuscleDefaultMinDelegate GetMuscleDefaultMinDelegateField = IL2CPP.ResolveICall<HumanTrait.GetMuscleDefaultMinDelegate>("UnityEngine.HumanTrait::GetMuscleDefaultMin");

		// Token: 0x0400038E RID: 910
		private static readonly HumanTrait.GetMuscleDefaultMaxDelegate GetMuscleDefaultMaxDelegateField = IL2CPP.ResolveICall<HumanTrait.GetMuscleDefaultMaxDelegate>("UnityEngine.HumanTrait::GetMuscleDefaultMax");

		// Token: 0x0400038F RID: 911
		private static readonly HumanTrait.Internal_GetBoneHierarchyMassDelegate Internal_GetBoneHierarchyMassDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_GetBoneHierarchyMassDelegate>("UnityEngine.HumanTrait::Internal_GetBoneHierarchyMass");

		// Token: 0x04000390 RID: 912
		private static readonly HumanTrait.Internal_GetParentDelegate Internal_GetParentDelegateField = IL2CPP.ResolveICall<HumanTrait.Internal_GetParentDelegate>("UnityEngine.HumanTrait::Internal_GetParent");

		// Token: 0x020001DF RID: 479
		// (Invoke) Token: 0x060008B4 RID: 2228
		private delegate int get_MuscleCountDelegate();

		// Token: 0x020001E0 RID: 480
		// (Invoke) Token: 0x060008B6 RID: 2230
		private delegate int GetBoneIndexFromMonoDelegate(int humanId);

		// Token: 0x020001E1 RID: 481
		// (Invoke) Token: 0x060008B8 RID: 2232
		private delegate int GetBoneIndexToMonoDelegate(int boneIndex);

		// Token: 0x020001E2 RID: 482
		// (Invoke) Token: 0x060008BA RID: 2234
		private delegate IntPtr get_MuscleNameDelegate();

		// Token: 0x020001E3 RID: 483
		// (Invoke) Token: 0x060008BC RID: 2236
		private delegate int get_BoneCountDelegate();

		// Token: 0x020001E4 RID: 484
		// (Invoke) Token: 0x060008BE RID: 2238
		private delegate IntPtr get_BoneNameDelegate();

		// Token: 0x020001E5 RID: 485
		// (Invoke) Token: 0x060008C0 RID: 2240
		private delegate int Internal_MuscleFromBoneDelegate(int i, int dofIndex);

		// Token: 0x020001E6 RID: 486
		// (Invoke) Token: 0x060008C2 RID: 2242
		private delegate int Internal_BoneFromMuscleDelegate(int i);

		// Token: 0x020001E7 RID: 487
		// (Invoke) Token: 0x060008C4 RID: 2244
		private delegate bool Internal_RequiredBoneDelegate(int i);

		// Token: 0x020001E8 RID: 488
		// (Invoke) Token: 0x060008C6 RID: 2246
		private delegate int get_RequiredBoneCountDelegate();

		// Token: 0x020001E9 RID: 489
		// (Invoke) Token: 0x060008C8 RID: 2248
		private delegate float GetMuscleDefaultMinDelegate(int i);

		// Token: 0x020001EA RID: 490
		// (Invoke) Token: 0x060008CA RID: 2250
		private delegate float GetMuscleDefaultMaxDelegate(int i);

		// Token: 0x020001EB RID: 491
		// (Invoke) Token: 0x060008CC RID: 2252
		private delegate float Internal_GetBoneHierarchyMassDelegate(int i);

		// Token: 0x020001EC RID: 492
		// (Invoke) Token: 0x060008CE RID: 2254
		private delegate int Internal_GetParentDelegate(int i);
	}
}
