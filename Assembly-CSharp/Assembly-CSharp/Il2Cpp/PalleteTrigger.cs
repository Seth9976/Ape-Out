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
	// Token: 0x0200014D RID: 333
	public class PalleteTrigger : MonoBehaviour
	{
		// Token: 0x06002835 RID: 10293 RVA: 0x000A3758 File Offset: 0x000A1958
		// Note: this type is marked as 'beforefieldinit'.
		static PalleteTrigger()
		{
			Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PalleteTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr);
			PalleteTrigger.NativeFieldInfoPtr_pallete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "pallete");
			PalleteTrigger.NativeFieldInfoPtr_stealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "stealth");
			PalleteTrigger.NativeFieldInfoPtr_unstealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "unstealth");
			PalleteTrigger.NativeFieldInfoPtr_bigDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "bigDoor");
			PalleteTrigger.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "lights");
			PalleteTrigger.NativeFieldInfoPtr_lit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "lit");
			PalleteTrigger.NativeFieldInfoPtr_trigged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "trigged");
			PalleteTrigger.NativeFieldInfoPtr_delaypt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "delaypt1");
			PalleteTrigger.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, 100666484);
			PalleteTrigger.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, 100666485);
			PalleteTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, 100666486);
			PalleteTrigger.NativeMethodInfoPtr_Flicker_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, 100666487);
			PalleteTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, 100666488);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x000A388C File Offset: 0x000A1A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75938, XrefRangeEnd = 75998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000A38C0 File Offset: 0x000A1AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75998, XrefRangeEnd = 76002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x000A38F4 File Offset: 0x000A1AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76002, XrefRangeEnd = 76011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000A3928 File Offset: 0x000A1B28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 76014, RefRangeEnd = 76017, XrefRangeStart = 76011, XrefRangeEnd = 76014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Flicker(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger.NativeMethodInfoPtr_Flicker_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000A3974 File Offset: 0x000A1B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76017, XrefRangeEnd = 76023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalleteTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0001C0C9 File Offset: 0x0001A2C9
		public PalleteTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x000A39B0 File Offset: 0x000A1BB0
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x0001C0D2 File Offset: 0x0001A2D2
		public unsafe string pallete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_pallete);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_pallete), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x000A39D8 File Offset: 0x000A1BD8
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x0001C0F1 File Offset: 0x0001A2F1
		public unsafe bool stealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_stealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_stealth)) = value;
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x000A3A00 File Offset: 0x000A1C00
		// (set) Token: 0x06002841 RID: 10305 RVA: 0x0001C10C File Offset: 0x0001A30C
		public unsafe bool unstealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_unstealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_unstealth)) = value;
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x000A3A28 File Offset: 0x000A1C28
		// (set) Token: 0x06002843 RID: 10307 RVA: 0x0001C127 File Offset: 0x0001A327
		public unsafe BigDoor bigDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_bigDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_bigDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x000A3A58 File Offset: 0x000A1C58
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x0001C146 File Offset: 0x0001A346
		public unsafe Il2CppReferenceArray<GameObject> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x000A3A88 File Offset: 0x000A1C88
		// (set) Token: 0x06002847 RID: 10311 RVA: 0x0001C165 File Offset: 0x0001A365
		public unsafe bool lit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_lit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_lit)) = value;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000A3AB0 File Offset: 0x000A1CB0
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x0001C180 File Offset: 0x0001A380
		public unsafe bool trigged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_trigged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_trigged)) = value;
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000A3AD8 File Offset: 0x000A1CD8
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x0001C19B File Offset: 0x0001A39B
		public unsafe WaitForSeconds delaypt1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_delaypt1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger.NativeFieldInfoPtr_delaypt1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017A6 RID: 6054
		private static readonly IntPtr NativeFieldInfoPtr_pallete;

		// Token: 0x040017A7 RID: 6055
		private static readonly IntPtr NativeFieldInfoPtr_stealth;

		// Token: 0x040017A8 RID: 6056
		private static readonly IntPtr NativeFieldInfoPtr_unstealth;

		// Token: 0x040017A9 RID: 6057
		private static readonly IntPtr NativeFieldInfoPtr_bigDoor;

		// Token: 0x040017AA RID: 6058
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x040017AB RID: 6059
		private static readonly IntPtr NativeFieldInfoPtr_lit;

		// Token: 0x040017AC RID: 6060
		private static readonly IntPtr NativeFieldInfoPtr_trigged;

		// Token: 0x040017AD RID: 6061
		private static readonly IntPtr NativeFieldInfoPtr_delaypt1;

		// Token: 0x040017AE RID: 6062
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040017AF RID: 6063
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040017B0 RID: 6064
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Public_Void_0;

		// Token: 0x040017B1 RID: 6065
		private static readonly IntPtr NativeMethodInfoPtr_Flicker_Private_IEnumerator_Int32_0;

		// Token: 0x040017B2 RID: 6066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200033E RID: 830
		[ObfuscatedName("PalleteTrigger+<Flicker>d__11")]
		public sealed class _Flicker_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06005255 RID: 21077 RVA: 0x0012B500 File Offset: 0x00129700
			// Note: this type is marked as 'beforefieldinit'.
			static _Flicker_d__11()
			{
				Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PalleteTrigger>.NativeClassPtr, "<Flicker>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr);
				PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, "<>1__state");
				PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, "<>2__current");
				PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, "i");
				PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, "<>4__this");
				PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, 100666489);
				PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, 100666490);
				PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, 100666491);
				PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, 100666492);
				PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, 100666493);
				PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr, 100666494);
			}

			// Token: 0x06005256 RID: 21078 RVA: 0x0012B5F4 File Offset: 0x001297F4
			[CallerCount(0)]
			public unsafe _Flicker_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalleteTrigger._Flicker_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005257 RID: 21079 RVA: 0x0012B63C File Offset: 0x0012983C
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005258 RID: 21080 RVA: 0x0012B670 File Offset: 0x00129870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75925, XrefRangeEnd = 75933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E08 RID: 7688
			// (get) Token: 0x06005259 RID: 21081 RVA: 0x0012B6AC File Offset: 0x001298AC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600525A RID: 21082 RVA: 0x0012B6EC File Offset: 0x001298EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75933, XrefRangeEnd = 75938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E09 RID: 7689
			// (get) Token: 0x0600525B RID: 21083 RVA: 0x0012B720 File Offset: 0x00129920
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalleteTrigger._Flicker_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600525C RID: 21084 RVA: 0x0002FF68 File Offset: 0x0002E168
			public _Flicker_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E04 RID: 7684
			// (get) Token: 0x0600525D RID: 21085 RVA: 0x0012B760 File Offset: 0x00129960
			// (set) Token: 0x0600525E RID: 21086 RVA: 0x0002FF71 File Offset: 0x0002E171
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E05 RID: 7685
			// (get) Token: 0x0600525F RID: 21087 RVA: 0x0012B788 File Offset: 0x00129988
			// (set) Token: 0x06005260 RID: 21088 RVA: 0x0002FF8C File Offset: 0x0002E18C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E06 RID: 7686
			// (get) Token: 0x06005261 RID: 21089 RVA: 0x0012B7B8 File Offset: 0x001299B8
			// (set) Token: 0x06005262 RID: 21090 RVA: 0x0002FFAB File Offset: 0x0002E1AB
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x17001E07 RID: 7687
			// (get) Token: 0x06005263 RID: 21091 RVA: 0x0012B7E0 File Offset: 0x001299E0
			// (set) Token: 0x06005264 RID: 21092 RVA: 0x0002FFC6 File Offset: 0x0002E1C6
			public unsafe PalleteTrigger __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PalleteTrigger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalleteTrigger._Flicker_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400366B RID: 13931
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400366C RID: 13932
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400366D RID: 13933
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x0400366E RID: 13934
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400366F RID: 13935
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003670 RID: 13936
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003671 RID: 13937
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003672 RID: 13938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003673 RID: 13939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003674 RID: 13940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
