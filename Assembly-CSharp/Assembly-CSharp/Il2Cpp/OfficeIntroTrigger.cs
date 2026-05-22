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
	// Token: 0x02000141 RID: 321
	public class OfficeIntroTrigger : MonoBehaviour
	{
		// Token: 0x060026EA RID: 9962 RVA: 0x000A061C File Offset: 0x0009E81C
		// Note: this type is marked as 'beforefieldinit'.
		static OfficeIntroTrigger()
		{
			Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OfficeIntroTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr);
			OfficeIntroTrigger.NativeFieldInfoPtr_guards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, "guards");
			OfficeIntroTrigger.NativeFieldInfoPtr_unMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, "unMoved");
			OfficeIntroTrigger.NativeFieldInfoPtr_centralNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, "centralNum");
			OfficeIntroTrigger.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, "me");
			OfficeIntroTrigger.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, "pos");
			OfficeIntroTrigger.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, 100666415);
			OfficeIntroTrigger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, 100666416);
			OfficeIntroTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, 100666417);
			OfficeIntroTrigger.NativeMethodInfoPtr_Teleport_Private_IEnumerator_GameObject_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, 100666418);
			OfficeIntroTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, 100666419);
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000A0714 File Offset: 0x0009E914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75219, XrefRangeEnd = 75221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000A0748 File Offset: 0x0009E948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75221, XrefRangeEnd = 75229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000A077C File Offset: 0x0009E97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75229, XrefRangeEnd = 75251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter2D(Collider2D coll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75251, XrefRangeEnd = 75254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Teleport(GameObject coll, Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(coll);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger.NativeMethodInfoPtr_Teleport_Private_IEnumerator_GameObject_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000A0820 File Offset: 0x0009EA20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OfficeIntroTrigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0001B1B2 File Offset: 0x000193B2
		public OfficeIntroTrigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x000A085C File Offset: 0x0009EA5C
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x0001B1BB File Offset: 0x000193BB
		public unsafe Il2CppReferenceArray<GuardState> guards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_guards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GuardState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_guards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x000A088C File Offset: 0x0009EA8C
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x0001B1DA File Offset: 0x000193DA
		public unsafe bool unMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_unMoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_unMoved)) = value;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000A08B4 File Offset: 0x0009EAB4
		// (set) Token: 0x060026F6 RID: 9974 RVA: 0x0001B1F5 File Offset: 0x000193F5
		public unsafe int centralNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_centralNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_centralNum)) = value;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x060026F7 RID: 9975 RVA: 0x000A08DC File Offset: 0x0009EADC
		// (set) Token: 0x060026F8 RID: 9976 RVA: 0x0001B210 File Offset: 0x00019410
		public unsafe static OfficeIntroTrigger me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(OfficeIntroTrigger.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfficeIntroTrigger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OfficeIntroTrigger.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000A0904 File Offset: 0x0009EB04
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x0001B222 File Offset: 0x00019422
		public unsafe Vector2 pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger.NativeFieldInfoPtr_pos)) = value;
			}
		}

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeFieldInfoPtr_guards;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeFieldInfoPtr_unMoved;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeFieldInfoPtr_centralNum;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeFieldInfoPtr_pos;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_Teleport_Private_IEnumerator_GameObject_Vector2_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200033A RID: 826
		[ObfuscatedName("OfficeIntroTrigger+<Teleport>d__8")]
		public sealed class _Teleport_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x0600521D RID: 21021 RVA: 0x0012A9B8 File Offset: 0x00128BB8
			// Note: this type is marked as 'beforefieldinit'.
			static _Teleport_d__8()
			{
				Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OfficeIntroTrigger>.NativeClassPtr, "<Teleport>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr);
				OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, "<>1__state");
				OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, "<>2__current");
				OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr_coll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, "coll");
				OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, "pos");
				OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, 100666420);
				OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, 100666421);
				OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, 100666422);
				OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, 100666423);
				OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, 100666424);
				OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr, 100666425);
			}

			// Token: 0x0600521E RID: 21022 RVA: 0x0012AAAC File Offset: 0x00128CAC
			[CallerCount(0)]
			public unsafe _Teleport_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OfficeIntroTrigger._Teleport_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600521F RID: 21023 RVA: 0x0012AAF4 File Offset: 0x00128CF4
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005220 RID: 21024 RVA: 0x0012AB28 File Offset: 0x00128D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75168, XrefRangeEnd = 75214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001DF4 RID: 7668
			// (get) Token: 0x06005221 RID: 21025 RVA: 0x0012AB64 File Offset: 0x00128D64
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005222 RID: 21026 RVA: 0x0012ABA4 File Offset: 0x00128DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75214, XrefRangeEnd = 75219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001DF5 RID: 7669
			// (get) Token: 0x06005223 RID: 21027 RVA: 0x0012ABD8 File Offset: 0x00128DD8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfficeIntroTrigger._Teleport_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005224 RID: 21028 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
			public _Teleport_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001DF0 RID: 7664
			// (get) Token: 0x06005225 RID: 21029 RVA: 0x0012AC18 File Offset: 0x00128E18
			// (set) Token: 0x06005226 RID: 21030 RVA: 0x0002FDED File Offset: 0x0002DFED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DF1 RID: 7665
			// (get) Token: 0x06005227 RID: 21031 RVA: 0x0012AC40 File Offset: 0x00128E40
			// (set) Token: 0x06005228 RID: 21032 RVA: 0x0002FE08 File Offset: 0x0002E008
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DF2 RID: 7666
			// (get) Token: 0x06005229 RID: 21033 RVA: 0x0012AC70 File Offset: 0x00128E70
			// (set) Token: 0x0600522A RID: 21034 RVA: 0x0002FE27 File Offset: 0x0002E027
			public unsafe GameObject coll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr_coll);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr_coll), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DF3 RID: 7667
			// (get) Token: 0x0600522B RID: 21035 RVA: 0x0012ACA0 File Offset: 0x00128EA0
			// (set) Token: 0x0600522C RID: 21036 RVA: 0x0002FE46 File Offset: 0x0002E046
			public unsafe Vector2 pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OfficeIntroTrigger._Teleport_d__8.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x04003647 RID: 13895
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003648 RID: 13896
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003649 RID: 13897
			private static readonly IntPtr NativeFieldInfoPtr_coll;

			// Token: 0x0400364A RID: 13898
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x0400364B RID: 13899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400364C RID: 13900
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400364D RID: 13901
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400364E RID: 13902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400364F RID: 13903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003650 RID: 13904
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
