using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000016 RID: 22
	public class Motion : Object
	{
		// Token: 0x06000291 RID: 657 RVA: 0x0000A40C File Offset: 0x0000860C
		// Note: this type is marked as 'beforefieldinit'.
		static Motion()
		{
			Il2CppClassPointerStore<Motion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "Motion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion>.NativeClassPtr);
			Motion.NativeFieldInfoPtr__isAnimatorMotion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion>.NativeClassPtr, "<isAnimatorMotion>k__BackingField");
			Motion.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion>.NativeClassPtr, 100663368);
			Motion.NativeMethodInfoPtr_get_isLooping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion>.NativeClassPtr, 100663369);
			Motion.get_averageDurationDelegateField = IL2CPP.ResolveICall<Motion.get_averageDurationDelegate>("UnityEngine.Motion::get_averageDuration");
			Motion.get_averageAngularSpeedDelegateField = IL2CPP.ResolveICall<Motion.get_averageAngularSpeedDelegate>("UnityEngine.Motion::get_averageAngularSpeed");
			Motion.get_apparentSpeedDelegateField = IL2CPP.ResolveICall<Motion.get_apparentSpeedDelegate>("UnityEngine.Motion::get_apparentSpeed");
			Motion.get_legacyDelegateField = IL2CPP.ResolveICall<Motion.get_legacyDelegate>("UnityEngine.Motion::get_legacy");
			Motion.get_isHumanMotionDelegateField = IL2CPP.ResolveICall<Motion.get_isHumanMotionDelegate>("UnityEngine.Motion::get_isHumanMotion");
			Motion.get_averageSpeed_InjectedDelegateField = IL2CPP.ResolveICall<Motion.get_averageSpeed_InjectedDelegate>("UnityEngine.Motion::get_averageSpeed_Injected");
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A4D4 File Offset: 0x000086D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483942, XrefRangeEnd = 483945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Motion()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Motion.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000A510 File Offset: 0x00008710
		public unsafe bool isLooping
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 483945, XrefRangeEnd = 483949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Motion.NativeMethodInfoPtr_get_isLooping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00003A87 File Offset: 0x00001C87
		public Motion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000A54C File Offset: 0x0000874C
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00003A90 File Offset: 0x00001C90
		public unsafe bool _isAnimatorMotion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Motion.NativeFieldInfoPtr__isAnimatorMotion_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Motion.NativeFieldInfoPtr__isAnimatorMotion_k__BackingField)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00003AAB File Offset: 0x00001CAB
		public float averageDuration
		{
			get
			{
				return Motion.get_averageDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00003ABD File Offset: 0x00001CBD
		public float averageAngularSpeed
		{
			get
			{
				return Motion.get_averageAngularSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000A574 File Offset: 0x00008774
		public Vector3 averageSpeed
		{
			get
			{
				Vector3 vector;
				this.get_averageSpeed_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00003ACF File Offset: 0x00001CCF
		public float apparentSpeed
		{
			get
			{
				return Motion.get_apparentSpeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00003AE1 File Offset: 0x00001CE1
		public bool legacy
		{
			get
			{
				return Motion.get_legacyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00003AF3 File Offset: 0x00001CF3
		public bool isHumanMotion
		{
			get
			{
				return Motion.get_isHumanMotionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000A58C File Offset: 0x0000878C
		public bool ValidateIfRetargetable(bool val)
		{
			return false;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00003B05 File Offset: 0x00001D05
		public bool isAnimatorMotion
		{
			get
			{
				return this._isAnimatorMotion_k__BackingField;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00003B0D File Offset: 0x00001D0D
		public void get_averageSpeed_Injected(out Vector3 ret)
		{
			Motion.get_averageSpeed_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr__isAnimatorMotion_k__BackingField;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_isLooping_Public_get_Boolean_0;

		// Token: 0x04000199 RID: 409
		private static readonly Motion.get_averageDurationDelegate get_averageDurationDelegateField;

		// Token: 0x0400019A RID: 410
		private static readonly Motion.get_averageAngularSpeedDelegate get_averageAngularSpeedDelegateField;

		// Token: 0x0400019B RID: 411
		private static readonly Motion.get_apparentSpeedDelegate get_apparentSpeedDelegateField;

		// Token: 0x0400019C RID: 412
		private static readonly Motion.get_legacyDelegate get_legacyDelegateField;

		// Token: 0x0400019D RID: 413
		private static readonly Motion.get_isHumanMotionDelegate get_isHumanMotionDelegateField;

		// Token: 0x0400019E RID: 414
		private static readonly Motion.get_averageSpeed_InjectedDelegate get_averageSpeed_InjectedDelegateField;

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x06000791 RID: 1937
		private delegate float get_averageDurationDelegate(IntPtr @this);

		// Token: 0x0200014E RID: 334
		// (Invoke) Token: 0x06000793 RID: 1939
		private delegate float get_averageAngularSpeedDelegate(IntPtr @this);

		// Token: 0x0200014F RID: 335
		// (Invoke) Token: 0x06000795 RID: 1941
		private delegate float get_apparentSpeedDelegate(IntPtr @this);

		// Token: 0x02000150 RID: 336
		// (Invoke) Token: 0x06000797 RID: 1943
		private delegate bool get_legacyDelegate(IntPtr @this);

		// Token: 0x02000151 RID: 337
		// (Invoke) Token: 0x06000799 RID: 1945
		private delegate bool get_isHumanMotionDelegate(IntPtr @this);

		// Token: 0x02000152 RID: 338
		// (Invoke) Token: 0x0600079B RID: 1947
		private delegate void get_averageSpeed_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
