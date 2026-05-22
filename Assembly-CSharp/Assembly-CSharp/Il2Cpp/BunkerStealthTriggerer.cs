using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000099 RID: 153
	public class BunkerStealthTriggerer : MonoBehaviour
	{
		// Token: 0x06001244 RID: 4676 RVA: 0x000689C8 File Offset: 0x00066BC8
		// Note: this type is marked as 'beforefieldinit'.
		static BunkerStealthTriggerer()
		{
			Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BunkerStealthTriggerer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr);
			BunkerStealthTriggerer.NativeFieldInfoPtr_bombDropping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "bombDropping");
			BunkerStealthTriggerer.NativeFieldInfoPtr_planeMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "planeMoving");
			BunkerStealthTriggerer.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "done");
			BunkerStealthTriggerer.NativeFieldInfoPtr_multiBombDropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "multiBombDropped");
			BunkerStealthTriggerer.NativeFieldInfoPtr_planeSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "planeSource");
			BunkerStealthTriggerer.NativeFieldInfoPtr_PlaneCueInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "PlaneCueInstance");
			BunkerStealthTriggerer.NativeFieldInfoPtr_texes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "texes");
			BunkerStealthTriggerer.NativeFieldInfoPtr_delaypt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "delaypt1");
			BunkerStealthTriggerer.NativeFieldInfoPtr_bombTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "bombTimer");
			BunkerStealthTriggerer.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, 100664848);
			BunkerStealthTriggerer.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, 100664849);
			BunkerStealthTriggerer.NativeMethodInfoPtr_Flicker_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, 100664850);
			BunkerStealthTriggerer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, 100664851);
			BunkerStealthTriggerer.NativeMethodInfoPtr__Update_b__10_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, 100664852);
			BunkerStealthTriggerer.NativeMethodInfoPtr__Update_b__10_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, 100664853);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00068B24 File Offset: 0x00066D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49793, XrefRangeEnd = 49817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00068B58 File Offset: 0x00066D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49817, XrefRangeEnd = 49937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00068B8C File Offset: 0x00066D8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 49940, RefRangeEnd = 49942, XrefRangeStart = 49937, XrefRangeEnd = 49940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flicker(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer.NativeMethodInfoPtr_Flicker_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00068BD8 File Offset: 0x00066DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49942, XrefRangeEnd = 49948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BunkerStealthTriggerer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00068C14 File Offset: 0x00066E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49948, XrefRangeEnd = 49952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _Update_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer.NativeMethodInfoPtr__Update_b__10_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00068C50 File Offset: 0x00066E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49952, XrefRangeEnd = 49953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Update_b__10_1(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer.NativeMethodInfoPtr__Update_b__10_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0000D633 File Offset: 0x0000B833
		public BunkerStealthTriggerer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00068C90 File Offset: 0x00066E90
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x0000D63C File Offset: 0x0000B83C
		public unsafe bool bombDropping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_bombDropping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_bombDropping)) = value;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00068CB8 File Offset: 0x00066EB8
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x0000D657 File Offset: 0x0000B857
		public unsafe bool planeMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_planeMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_planeMoving)) = value;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00068CE0 File Offset: 0x00066EE0
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x0000D672 File Offset: 0x0000B872
		public unsafe bool done
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_done);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_done)) = value;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00068D08 File Offset: 0x00066F08
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x0000D68D File Offset: 0x0000B88D
		public unsafe bool multiBombDropped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_multiBombDropped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_multiBombDropped)) = value;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00068D30 File Offset: 0x00066F30
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public unsafe SECTR_PointSource planeSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_planeSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_PointSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_planeSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00068D60 File Offset: 0x00066F60
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0000D6C7 File Offset: 0x0000B8C7
		public SECTR_AudioCueInstance PlaneCueInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_PlaneCueInstance);
				return new SECTR_AudioCueInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_PlaneCueInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SECTR_AudioCueInstance>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00068D90 File Offset: 0x00066F90
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000D6F5 File Offset: 0x0000B8F5
		public unsafe Il2CppReferenceArray<Texture> texes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_texes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_texes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00068DC0 File Offset: 0x00066FC0
		// (set) Token: 0x0600125B RID: 4699 RVA: 0x0000D714 File Offset: 0x0000B914
		public unsafe WaitForSeconds delaypt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_delaypt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_delaypt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00068DF0 File Offset: 0x00066FF0
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x0000D733 File Offset: 0x0000B933
		public unsafe float bombTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_bombTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer.NativeFieldInfoPtr_bombTimer)) = value;
			}
		}

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeFieldInfoPtr_bombDropping;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeFieldInfoPtr_planeMoving;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_done;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeFieldInfoPtr_multiBombDropped;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeFieldInfoPtr_planeSource;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeFieldInfoPtr_PlaneCueInstance;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeFieldInfoPtr_texes;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeFieldInfoPtr_delaypt1;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeFieldInfoPtr_bombTimer;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04000B08 RID: 2824
		private static readonly IntPtr NativeMethodInfoPtr_Flicker_Private_IEnumerator_Int32_0;

		// Token: 0x04000B09 RID: 2825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B0A RID: 2826
		private static readonly IntPtr NativeMethodInfoPtr__Update_b__10_0_Private_Single_0;

		// Token: 0x04000B0B RID: 2827
		private static readonly IntPtr NativeMethodInfoPtr__Update_b__10_1_Private_Void_Single_0;

		// Token: 0x020002E3 RID: 739
		[ObfuscatedName("BunkerStealthTriggerer+<Flicker>d__11")]
		public sealed class _Flicker_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06004DC8 RID: 19912 RVA: 0x0011D900 File Offset: 0x0011BB00
			// Note: this type is marked as 'beforefieldinit'.
			static _Flicker_d__11()
			{
				Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BunkerStealthTriggerer>.NativeClassPtr, "<Flicker>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr);
				BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, "<>1__state");
				BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, "<>2__current");
				BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, "i");
				BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, "<>4__this");
				BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, 100664854);
				BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, 100664855);
				BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, 100664856);
				BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, 100664857);
				BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, 100664858);
				BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr, 100664859);
			}

			// Token: 0x06004DC9 RID: 19913 RVA: 0x0011D9F4 File Offset: 0x0011BBF4
			[CallerCount(0)]
			public unsafe _Flicker_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BunkerStealthTriggerer._Flicker_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DCA RID: 19914 RVA: 0x0011DA3C File Offset: 0x0011BC3C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DCB RID: 19915 RVA: 0x0011DA70 File Offset: 0x0011BC70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49776, XrefRangeEnd = 49788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C58 RID: 7256
			// (get) Token: 0x06004DCC RID: 19916 RVA: 0x0011DAAC File Offset: 0x0011BCAC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DCD RID: 19917 RVA: 0x0011DAEC File Offset: 0x0011BCEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49788, XrefRangeEnd = 49793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C59 RID: 7257
			// (get) Token: 0x06004DCE RID: 19918 RVA: 0x0011DB20 File Offset: 0x0011BD20
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BunkerStealthTriggerer._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DCF RID: 19919 RVA: 0x0002DA7F File Offset: 0x0002BC7F
			public _Flicker_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C54 RID: 7252
			// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x0011DB60 File Offset: 0x0011BD60
			// (set) Token: 0x06004DD1 RID: 19921 RVA: 0x0002DA88 File Offset: 0x0002BC88
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C55 RID: 7253
			// (get) Token: 0x06004DD2 RID: 19922 RVA: 0x0011DB88 File Offset: 0x0011BD88
			// (set) Token: 0x06004DD3 RID: 19923 RVA: 0x0002DAA3 File Offset: 0x0002BCA3
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C56 RID: 7254
			// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x0011DBB8 File Offset: 0x0011BDB8
			// (set) Token: 0x06004DD5 RID: 19925 RVA: 0x0002DAC2 File Offset: 0x0002BCC2
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17001C57 RID: 7255
			// (get) Token: 0x06004DD6 RID: 19926 RVA: 0x0011DBE0 File Offset: 0x0011BDE0
			// (set) Token: 0x06004DD7 RID: 19927 RVA: 0x0002DADD File Offset: 0x0002BCDD
			public unsafe BunkerStealthTriggerer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunkerStealthTriggerer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BunkerStealthTriggerer._Flicker_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040032EC RID: 13036
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040032ED RID: 13037
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040032EE RID: 13038
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x040032EF RID: 13039
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040032F0 RID: 13040
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040032F1 RID: 13041
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032F2 RID: 13042
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040032F3 RID: 13043
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040032F4 RID: 13044
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040032F5 RID: 13045
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
