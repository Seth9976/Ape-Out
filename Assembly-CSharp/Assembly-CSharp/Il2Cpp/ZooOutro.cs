using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001D6 RID: 470
	public class ZooOutro : MonoBehaviour
	{
		// Token: 0x060032C2 RID: 12994 RVA: 0x000BFB2C File Offset: 0x000BDD2C
		// Note: this type is marked as 'beforefieldinit'.
		static ZooOutro()
		{
			Il2CppClassPointerStore<ZooOutro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ZooOutro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr);
			ZooOutro.NativeFieldInfoPtr_goin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "goin");
			ZooOutro.NativeFieldInfoPtr_credits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "credits");
			ZooOutro.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "me");
			ZooOutro.NativeFieldInfoPtr_splatColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "splatColors");
			ZooOutro.NativeFieldInfoPtr_splatMats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "splatMats");
			ZooOutro.NativeFieldInfoPtr_matList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "matList");
			ZooOutro.NativeFieldInfoPtr_nOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "nOffset");
			ZooOutro.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, 100667245);
			ZooOutro.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, 100667246);
			ZooOutro.NativeMethodInfoPtr_DoIt_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, 100667247);
			ZooOutro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, 100667248);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000BFC38 File Offset: 0x000BDE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86132, XrefRangeEnd = 86140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x000BFC6C File Offset: 0x000BDE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86140, XrefRangeEnd = 86160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000BFCA0 File Offset: 0x000BDEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86160, XrefRangeEnd = 86163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoIt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro.NativeMethodInfoPtr_DoIt_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x000BFCE0 File Offset: 0x000BDEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ZooOutro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00022BDD File Offset: 0x00020DDD
		public ZooOutro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x000BFD1C File Offset: 0x000BDF1C
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x00022BE6 File Offset: 0x00020DE6
		public unsafe bool goin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_goin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_goin)) = value;
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x000BFD44 File Offset: 0x000BDF44
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00022C01 File Offset: 0x00020E01
		public unsafe GameObject credits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_credits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_credits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x000BFD74 File Offset: 0x000BDF74
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x00022C20 File Offset: 0x00020E20
		public unsafe static ZooOutro me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ZooOutro.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZooOutro>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ZooOutro.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x000BFD9C File Offset: 0x000BDF9C
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x00022C32 File Offset: 0x00020E32
		public unsafe Il2CppStructArray<Color> splatColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_splatColors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_splatColors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x000BFDCC File Offset: 0x000BDFCC
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x00022C51 File Offset: 0x00020E51
		public unsafe Il2CppReferenceArray<Material> splatMats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_splatMats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_splatMats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x000BFDFC File Offset: 0x000BDFFC
		// (set) Token: 0x060032D3 RID: 13011 RVA: 0x00022C70 File Offset: 0x00020E70
		public unsafe List<Material> matList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_matList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_matList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x000BFE2C File Offset: 0x000BE02C
		// (set) Token: 0x060032D5 RID: 13013 RVA: 0x00022C8F File Offset: 0x00020E8F
		public unsafe Vector4 nOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_nOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro.NativeFieldInfoPtr_nOffset)) = value;
			}
		}

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeFieldInfoPtr_goin;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeFieldInfoPtr_credits;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeFieldInfoPtr_splatColors;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeFieldInfoPtr_splatMats;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeFieldInfoPtr_matList;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeFieldInfoPtr_nOffset;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_DoIt_Public_IEnumerator_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000356 RID: 854
		[ObfuscatedName("ZooOutro+<DoIt>d__9")]
		public sealed class _DoIt_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x060053BC RID: 21436 RVA: 0x0012F8E8 File Offset: 0x0012DAE8
			// Note: this type is marked as 'beforefieldinit'.
			static _DoIt_d__9()
			{
				Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ZooOutro>.NativeClassPtr, "<DoIt>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr);
				ZooOutro._DoIt_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, "<>1__state");
				ZooOutro._DoIt_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, "<>2__current");
				ZooOutro._DoIt_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, "<>4__this");
				ZooOutro._DoIt_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, 100667249);
				ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, 100667250);
				ZooOutro._DoIt_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, 100667251);
				ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, 100667252);
				ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, 100667253);
				ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr, 100667254);
			}

			// Token: 0x060053BD RID: 21437 RVA: 0x0012F9C8 File Offset: 0x0012DBC8
			[CallerCount(0)]
			public unsafe _DoIt_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZooOutro._DoIt_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro._DoIt_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053BE RID: 21438 RVA: 0x0012FA10 File Offset: 0x0012DC10
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053BF RID: 21439 RVA: 0x0012FA44 File Offset: 0x0012DC44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85997, XrefRangeEnd = 86127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro._DoIt_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E8A RID: 7818
			// (get) Token: 0x060053C0 RID: 21440 RVA: 0x0012FA80 File Offset: 0x0012DC80
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053C1 RID: 21441 RVA: 0x0012FAC0 File Offset: 0x0012DCC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86127, XrefRangeEnd = 86132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E8B RID: 7819
			// (get) Token: 0x060053C2 RID: 21442 RVA: 0x0012FAF4 File Offset: 0x0012DCF4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ZooOutro._DoIt_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053C3 RID: 21443 RVA: 0x00030B1C File Offset: 0x0002ED1C
			public _DoIt_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E87 RID: 7815
			// (get) Token: 0x060053C4 RID: 21444 RVA: 0x0012FB34 File Offset: 0x0012DD34
			// (set) Token: 0x060053C5 RID: 21445 RVA: 0x00030B25 File Offset: 0x0002ED25
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro._DoIt_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro._DoIt_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E88 RID: 7816
			// (get) Token: 0x060053C6 RID: 21446 RVA: 0x0012FB5C File Offset: 0x0012DD5C
			// (set) Token: 0x060053C7 RID: 21447 RVA: 0x00030B40 File Offset: 0x0002ED40
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro._DoIt_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro._DoIt_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E89 RID: 7817
			// (get) Token: 0x060053C8 RID: 21448 RVA: 0x0012FB8C File Offset: 0x0012DD8C
			// (set) Token: 0x060053C9 RID: 21449 RVA: 0x00030B5F File Offset: 0x0002ED5F
			public unsafe ZooOutro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro._DoIt_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ZooOutro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ZooOutro._DoIt_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003753 RID: 14163
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003754 RID: 14164
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003755 RID: 14165
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003756 RID: 14166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003757 RID: 14167
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003758 RID: 14168
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003759 RID: 14169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400375A RID: 14170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400375B RID: 14171
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
