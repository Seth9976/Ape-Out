using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000066 RID: 102
	public sealed class LightProbes : Object
	{
		// Token: 0x060006F0 RID: 1776 RVA: 0x00026F80 File Offset: 0x00025180
		// Note: this type is marked as 'beforefieldinit'.
		static LightProbes()
		{
			Il2CppClassPointerStore<LightProbes>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbes");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbes>.NativeClassPtr);
			LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "tetrahedralizationCompleted");
			LightProbes.NativeFieldInfoPtr_needsRetetrahedralization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, "needsRetetrahedralization");
			LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100663823);
			LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightProbes>.NativeClassPtr, 100663824);
			LightProbes.TetrahedralizeDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeDelegate>("UnityEngine.LightProbes::Tetrahedralize");
			LightProbes.TetrahedralizeAsyncDelegateField = IL2CPP.ResolveICall<LightProbes.TetrahedralizeAsyncDelegate>("UnityEngine.LightProbes::TetrahedralizeAsync");
			LightProbes.AreLightProbesAllowedDelegateField = IL2CPP.ResolveICall<LightProbes.AreLightProbesAllowedDelegate>("UnityEngine.LightProbes::AreLightProbesAllowed");
			LightProbes.get_positionsDelegateField = IL2CPP.ResolveICall<LightProbes.get_positionsDelegate>("UnityEngine.LightProbes::get_positions");
			LightProbes.get_countDelegateField = IL2CPP.ResolveICall<LightProbes.get_countDelegate>("UnityEngine.LightProbes::get_count");
			LightProbes.get_cellCountDelegateField = IL2CPP.ResolveICall<LightProbes.get_cellCountDelegate>("UnityEngine.LightProbes::get_cellCount");
			LightProbes.GetCountDelegateField = IL2CPP.ResolveICall<LightProbes.GetCountDelegate>("UnityEngine.LightProbes::GetCount");
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0002706C File Offset: 0x0002526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488115, XrefRangeEnd = 488118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallTetrahedralizationCompletedFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00027094 File Offset: 0x00025294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488118, XrefRangeEnd = 488121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_CallNeedsRetetrahedralizationFunction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightProbes.NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00005784 File Offset: 0x00003984
		public LightProbes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000270BC File Offset: 0x000252BC
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0000578D File Offset: 0x0000398D
		public unsafe static Action tetrahedralizationCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_tetrahedralizationCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000270E4 File Offset: 0x000252E4
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0000579F File Offset: 0x0000399F
		public unsafe static Action needsRetetrahedralization
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightProbes.NativeFieldInfoPtr_needsRetetrahedralization, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000057B1 File Offset: 0x000039B1
		public static void Tetrahedralize()
		{
			LightProbes.TetrahedralizeDelegateField();
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x000057BD File Offset: 0x000039BD
		public static void TetrahedralizeAsync()
		{
			LightProbes.TetrahedralizeAsyncDelegateField();
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x000057C9 File Offset: 0x000039C9
		public static bool AreLightProbesAllowed(Renderer renderer)
		{
			return LightProbes.AreLightProbesAllowedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(renderer));
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x0002710C File Offset: 0x0002530C
		public Il2CppStructArray<Vector3> positions
		{
			get
			{
				IntPtr intPtr = LightProbes.get_positionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000057DB File Offset: 0x000039DB
		public int count
		{
			get
			{
				return LightProbes.get_countDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x000057ED File Offset: 0x000039ED
		public int cellCount
		{
			get
			{
				return LightProbes.get_cellCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000057FF File Offset: 0x000039FF
		public static int GetCount()
		{
			return LightProbes.GetCountDelegateField();
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0000580B File Offset: 0x00003A0B
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, Il2CppStructArray<float> coefficients)
		{
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0000580E File Offset: 0x00003A0E
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0000581B File Offset: 0x00003A1B
		public Il2CppStructArray<float> coefficients
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
			}
		}

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_tetrahedralizationCompleted;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_needsRetetrahedralization;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallTetrahedralizationCompletedFunction_Private_Static_Void_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_Internal_CallNeedsRetetrahedralizationFunction_Private_Static_Void_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly LightProbes.TetrahedralizeDelegate TetrahedralizeDelegateField;

		// Token: 0x040004D1 RID: 1233
		private static readonly LightProbes.TetrahedralizeAsyncDelegate TetrahedralizeAsyncDelegateField;

		// Token: 0x040004D2 RID: 1234
		private static readonly LightProbes.AreLightProbesAllowedDelegate AreLightProbesAllowedDelegateField;

		// Token: 0x040004D3 RID: 1235
		private static readonly LightProbes.get_positionsDelegate get_positionsDelegateField;

		// Token: 0x040004D4 RID: 1236
		private static readonly LightProbes.get_countDelegate get_countDelegateField;

		// Token: 0x040004D5 RID: 1237
		private static readonly LightProbes.get_cellCountDelegate get_cellCountDelegateField;

		// Token: 0x040004D6 RID: 1238
		private static readonly LightProbes.GetCountDelegate GetCountDelegateField;

		// Token: 0x02000497 RID: 1175
		// (Invoke) Token: 0x06002764 RID: 10084
		private delegate void TetrahedralizeDelegate();

		// Token: 0x02000498 RID: 1176
		// (Invoke) Token: 0x06002766 RID: 10086
		private delegate void TetrahedralizeAsyncDelegate();

		// Token: 0x02000499 RID: 1177
		// (Invoke) Token: 0x06002768 RID: 10088
		private delegate bool AreLightProbesAllowedDelegate(IntPtr renderer);

		// Token: 0x0200049A RID: 1178
		// (Invoke) Token: 0x0600276A RID: 10090
		private delegate IntPtr get_positionsDelegate(IntPtr @this);

		// Token: 0x0200049B RID: 1179
		// (Invoke) Token: 0x0600276C RID: 10092
		private delegate int get_countDelegate(IntPtr @this);

		// Token: 0x0200049C RID: 1180
		// (Invoke) Token: 0x0600276E RID: 10094
		private delegate int get_cellCountDelegate(IntPtr @this);

		// Token: 0x0200049D RID: 1181
		// (Invoke) Token: 0x06002770 RID: 10096
		private delegate int GetCountDelegate();
	}
}
