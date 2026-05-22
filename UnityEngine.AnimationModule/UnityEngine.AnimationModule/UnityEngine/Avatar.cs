using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000F RID: 15
	public class Avatar : Object
	{
		// Token: 0x0600020C RID: 524 RVA: 0x00009630 File Offset: 0x00007830
		// Note: this type is marked as 'beforefieldinit'.
		static Avatar()
		{
			Il2CppClassPointerStore<Avatar>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Avatar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Avatar>.NativeClassPtr);
			Avatar.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100663360);
			Avatar.NativeMethodInfoPtr_get_humanDescription_Public_get_HumanDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100663361);
			Avatar.NativeMethodInfoPtr_get_humanDescription_Injected_Private_Void_byref_HumanDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Avatar>.NativeClassPtr, 100663362);
			Avatar.get_isValidDelegateField = IL2CPP.ResolveICall<Avatar.get_isValidDelegate>("UnityEngine.Avatar::get_isValid");
			Avatar.get_isHumanDelegateField = IL2CPP.ResolveICall<Avatar.get_isHumanDelegate>("UnityEngine.Avatar::get_isHuman");
			Avatar.SetMuscleMinMaxDelegateField = IL2CPP.ResolveICall<Avatar.SetMuscleMinMaxDelegate>("UnityEngine.Avatar::SetMuscleMinMax");
			Avatar.SetParameterDelegateField = IL2CPP.ResolveICall<Avatar.SetParameterDelegate>("UnityEngine.Avatar::SetParameter");
			Avatar.Internal_GetAxisLengthDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetAxisLengthDelegate>("UnityEngine.Avatar::Internal_GetAxisLength");
			Avatar.Internal_GetPreRotation_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetPreRotation_InjectedDelegate>("UnityEngine.Avatar::Internal_GetPreRotation_Injected");
			Avatar.Internal_GetPostRotation_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetPostRotation_InjectedDelegate>("UnityEngine.Avatar::Internal_GetPostRotation_Injected");
			Avatar.Internal_GetZYPostQ_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetZYPostQ_InjectedDelegate>("UnityEngine.Avatar::Internal_GetZYPostQ_Injected");
			Avatar.Internal_GetZYRoll_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetZYRoll_InjectedDelegate>("UnityEngine.Avatar::Internal_GetZYRoll_Injected");
			Avatar.Internal_GetLimitSign_InjectedDelegateField = IL2CPP.ResolveICall<Avatar.Internal_GetLimitSign_InjectedDelegate>("UnityEngine.Avatar::Internal_GetLimitSign_Injected");
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00009734 File Offset: 0x00007934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483911, XrefRangeEnd = 483914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Avatar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Avatar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00009770 File Offset: 0x00007970
		public unsafe HumanDescription humanDescription
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483914, XrefRangeEnd = 483916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_humanDescription_Public_get_HumanDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new HumanDescription(intPtr);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000097A8 File Offset: 0x000079A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483916, XrefRangeEnd = 483920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void get_humanDescription_Injected(out HumanDescription ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Avatar.NativeMethodInfoPtr_get_humanDescription_Injected_Private_Void_byref_HumanDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				ret = ((intPtr4 == 0) ? null : new HumanDescription(intPtr4));
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00003561 File Offset: 0x00001761
		public Avatar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000356A File Offset: 0x0000176A
		public bool isValid
		{
			get
			{
				return Avatar.get_isValidDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000212 RID: 530 RVA: 0x0000357C File Offset: 0x0000177C
		public bool isHuman
		{
			get
			{
				return Avatar.get_isHumanDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000358E File Offset: 0x0000178E
		public void SetMuscleMinMax(int muscleId, float min, float max)
		{
			Avatar.SetMuscleMinMaxDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), muscleId, min, max);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000035A3 File Offset: 0x000017A3
		public void SetParameter(int parameterId, float value)
		{
			Avatar.SetParameterDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), parameterId, value);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000097FC File Offset: 0x000079FC
		public float GetAxisLength(int humanId)
		{
			return this.Internal_GetAxisLength(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000981C File Offset: 0x00007A1C
		public Quaternion GetPreRotation(int humanId)
		{
			return this.Internal_GetPreRotation(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000983C File Offset: 0x00007A3C
		public Quaternion GetPostRotation(int humanId)
		{
			return this.Internal_GetPostRotation(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000985C File Offset: 0x00007A5C
		public Quaternion GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			return this.Internal_GetZYPostQ(HumanTrait.GetBoneIndexFromMono(humanId), parentQ, q);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000987C File Offset: 0x00007A7C
		public Quaternion GetZYRoll(int humanId, Vector3 uvw)
		{
			return this.Internal_GetZYRoll(HumanTrait.GetBoneIndexFromMono(humanId), uvw);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000989C File Offset: 0x00007A9C
		public Vector3 GetLimitSign(int humanId)
		{
			return this.Internal_GetLimitSign(HumanTrait.GetBoneIndexFromMono(humanId));
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000035B7 File Offset: 0x000017B7
		public float Internal_GetAxisLength(int humanId)
		{
			return Avatar.Internal_GetAxisLengthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000098BC File Offset: 0x00007ABC
		public Quaternion Internal_GetPreRotation(int humanId)
		{
			Quaternion quaternion;
			this.Internal_GetPreRotation_Injected(humanId, out quaternion);
			return quaternion;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000098D4 File Offset: 0x00007AD4
		public Quaternion Internal_GetPostRotation(int humanId)
		{
			Quaternion quaternion;
			this.Internal_GetPostRotation_Injected(humanId, out quaternion);
			return quaternion;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000098EC File Offset: 0x00007AEC
		public Quaternion Internal_GetZYPostQ(int humanId, Quaternion parentQ, Quaternion q)
		{
			Quaternion quaternion;
			this.Internal_GetZYPostQ_Injected(humanId, ref parentQ, ref q, out quaternion);
			return quaternion;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00009908 File Offset: 0x00007B08
		public Quaternion Internal_GetZYRoll(int humanId, Vector3 uvw)
		{
			Quaternion quaternion;
			this.Internal_GetZYRoll_Injected(humanId, ref uvw, out quaternion);
			return quaternion;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00009924 File Offset: 0x00007B24
		public Vector3 Internal_GetLimitSign(int humanId)
		{
			Vector3 vector;
			this.Internal_GetLimitSign_Injected(humanId, out vector);
			return vector;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000035CA File Offset: 0x000017CA
		public void Internal_GetPreRotation_Injected(int humanId, out Quaternion ret)
		{
			Avatar.Internal_GetPreRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000035DE File Offset: 0x000017DE
		public void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret)
		{
			Avatar.Internal_GetPostRotation_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000035F2 File Offset: 0x000017F2
		public void Internal_GetZYPostQ_Injected(int humanId, ref Quaternion parentQ, ref Quaternion q, out Quaternion ret)
		{
			Avatar.Internal_GetZYPostQ_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, ref parentQ, ref q, out ret);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00003609 File Offset: 0x00001809
		public void Internal_GetZYRoll_Injected(int humanId, ref Vector3 uvw, out Quaternion ret)
		{
			Avatar.Internal_GetZYRoll_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, ref uvw, out ret);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000361E File Offset: 0x0000181E
		public void Internal_GetLimitSign_Injected(int humanId, out Vector3 ret)
		{
			Avatar.Internal_GetLimitSign_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), humanId, out ret);
		}

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_get_humanDescription_Public_get_HumanDescription_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_get_humanDescription_Injected_Private_Void_byref_HumanDescription_0;

		// Token: 0x04000150 RID: 336
		private static readonly Avatar.get_isValidDelegate get_isValidDelegateField;

		// Token: 0x04000151 RID: 337
		private static readonly Avatar.get_isHumanDelegate get_isHumanDelegateField;

		// Token: 0x04000152 RID: 338
		private static readonly Avatar.SetMuscleMinMaxDelegate SetMuscleMinMaxDelegateField;

		// Token: 0x04000153 RID: 339
		private static readonly Avatar.SetParameterDelegate SetParameterDelegateField;

		// Token: 0x04000154 RID: 340
		private static readonly Avatar.Internal_GetAxisLengthDelegate Internal_GetAxisLengthDelegateField;

		// Token: 0x04000155 RID: 341
		private static readonly Avatar.Internal_GetPreRotation_InjectedDelegate Internal_GetPreRotation_InjectedDelegateField;

		// Token: 0x04000156 RID: 342
		private static readonly Avatar.Internal_GetPostRotation_InjectedDelegate Internal_GetPostRotation_InjectedDelegateField;

		// Token: 0x04000157 RID: 343
		private static readonly Avatar.Internal_GetZYPostQ_InjectedDelegate Internal_GetZYPostQ_InjectedDelegateField;

		// Token: 0x04000158 RID: 344
		private static readonly Avatar.Internal_GetZYRoll_InjectedDelegate Internal_GetZYRoll_InjectedDelegateField;

		// Token: 0x04000159 RID: 345
		private static readonly Avatar.Internal_GetLimitSign_InjectedDelegate Internal_GetLimitSign_InjectedDelegateField;

		// Token: 0x0200013B RID: 315
		// (Invoke) Token: 0x0600076D RID: 1901
		private delegate bool get_isValidDelegate(IntPtr @this);

		// Token: 0x0200013C RID: 316
		// (Invoke) Token: 0x0600076F RID: 1903
		private delegate bool get_isHumanDelegate(IntPtr @this);

		// Token: 0x0200013D RID: 317
		// (Invoke) Token: 0x06000771 RID: 1905
		private delegate void SetMuscleMinMaxDelegate(IntPtr @this, int muscleId, float min, float max);

		// Token: 0x0200013E RID: 318
		// (Invoke) Token: 0x06000773 RID: 1907
		private delegate void SetParameterDelegate(IntPtr @this, int parameterId, float value);

		// Token: 0x0200013F RID: 319
		// (Invoke) Token: 0x06000775 RID: 1909
		private delegate float Internal_GetAxisLengthDelegate(IntPtr @this, int humanId);

		// Token: 0x02000140 RID: 320
		// (Invoke) Token: 0x06000777 RID: 1911
		private delegate void Internal_GetPreRotation_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);

		// Token: 0x02000141 RID: 321
		// (Invoke) Token: 0x06000779 RID: 1913
		private delegate void Internal_GetPostRotation_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);

		// Token: 0x02000142 RID: 322
		// (Invoke) Token: 0x0600077B RID: 1915
		private delegate void Internal_GetZYPostQ_InjectedDelegate(IntPtr @this, int humanId, IntPtr parentQ, IntPtr q, [Out] IntPtr ret);

		// Token: 0x02000143 RID: 323
		// (Invoke) Token: 0x0600077D RID: 1917
		private delegate void Internal_GetZYRoll_InjectedDelegate(IntPtr @this, int humanId, IntPtr uvw, [Out] IntPtr ret);

		// Token: 0x02000144 RID: 324
		// (Invoke) Token: 0x0600077F RID: 1919
		private delegate void Internal_GetLimitSign_InjectedDelegate(IntPtr @this, int humanId, [Out] IntPtr ret);
	}
}
