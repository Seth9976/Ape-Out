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
	// Token: 0x02000110 RID: 272
	public class Intro : MonoBehaviour
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x0008EBC8 File Offset: 0x0008CDC8
		// Note: this type is marked as 'beforefieldinit'.
		static Intro()
		{
			Il2CppClassPointerStore<Intro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Intro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intro>.NativeClassPtr);
			Intro.NativeFieldInfoPtr_blackScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "blackScreen");
			Intro.NativeFieldInfoPtr_greenScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "greenScreen");
			Intro.NativeFieldInfoPtr_jungleSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "jungleSound");
			Intro.NativeFieldInfoPtr_zipperSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "zipperSound");
			Intro.NativeFieldInfoPtr_unJungling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "unJungling");
			Intro.NativeFieldInfoPtr_truckSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "truckSound");
			Intro.NativeFieldInfoPtr_shotSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "shotSound");
			Intro.NativeFieldInfoPtr_grassSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "grassSound");
			Intro.NativeFieldInfoPtr_vibraSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "vibraSound");
			Intro.NativeFieldInfoPtr_crate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "crate");
			Intro.NativeFieldInfoPtr_cratePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "cratePos");
			Intro.NativeFieldInfoPtr_roads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro>.NativeClassPtr, "roads");
			Intro.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro>.NativeClassPtr, 100665848);
			Intro.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro>.NativeClassPtr, 100665849);
			Intro.NativeMethodInfoPtr_GoIntro_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro>.NativeClassPtr, 100665850);
			Intro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro>.NativeClassPtr, 100665851);
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0008ED38 File Offset: 0x0008CF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67660, XrefRangeEnd = 67688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0008ED6C File Offset: 0x0008CF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67688, XrefRangeEnd = 67698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0008EDA0 File Offset: 0x0008CFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67698, XrefRangeEnd = 67701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GoIntro()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro.NativeMethodInfoPtr_GoIntro_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0008EDE0 File Offset: 0x0008CFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Intro()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intro>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00016938 File Offset: 0x00014B38
		public Intro(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x0008EE1C File Offset: 0x0008D01C
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00016941 File Offset: 0x00014B41
		public unsafe GameObject blackScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_blackScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_blackScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0008EE4C File Offset: 0x0008D04C
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00016960 File Offset: 0x00014B60
		public unsafe GameObject greenScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_greenScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_greenScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x0008EE7C File Offset: 0x0008D07C
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x0001697F File Offset: 0x00014B7F
		public unsafe AudioSource jungleSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_jungleSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_jungleSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x0008EEAC File Offset: 0x0008D0AC
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x0001699E File Offset: 0x00014B9E
		public unsafe AudioSource zipperSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_zipperSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_zipperSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x0008EEDC File Offset: 0x0008D0DC
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x000169BD File Offset: 0x00014BBD
		public unsafe bool unJungling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_unJungling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_unJungling)) = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x0008EF04 File Offset: 0x0008D104
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x000169D8 File Offset: 0x00014BD8
		public unsafe AudioSource truckSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_truckSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_truckSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0008EF34 File Offset: 0x0008D134
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x000169F7 File Offset: 0x00014BF7
		public unsafe AudioSource shotSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_shotSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_shotSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0008EF64 File Offset: 0x0008D164
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x00016A16 File Offset: 0x00014C16
		public unsafe AudioSource grassSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_grassSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_grassSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0008EF94 File Offset: 0x0008D194
		// (set) Token: 0x06002064 RID: 8292 RVA: 0x00016A35 File Offset: 0x00014C35
		public unsafe AudioSource vibraSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_vibraSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_vibraSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x0008EFC4 File Offset: 0x0008D1C4
		// (set) Token: 0x06002066 RID: 8294 RVA: 0x00016A54 File Offset: 0x00014C54
		public unsafe GameObject crate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_crate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_crate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0008EFF4 File Offset: 0x0008D1F4
		// (set) Token: 0x06002068 RID: 8296 RVA: 0x00016A73 File Offset: 0x00014C73
		public unsafe Vector2 cratePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_cratePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_cratePos)) = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0008F01C File Offset: 0x0008D21C
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00016A8E File Offset: 0x00014C8E
		public unsafe Il2CppReferenceArray<GameObject> roads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_roads);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro.NativeFieldInfoPtr_roads), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeFieldInfoPtr_blackScreen;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_greenScreen;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeFieldInfoPtr_jungleSound;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeFieldInfoPtr_zipperSound;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeFieldInfoPtr_unJungling;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeFieldInfoPtr_truckSound;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeFieldInfoPtr_shotSound;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeFieldInfoPtr_grassSound;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeFieldInfoPtr_vibraSound;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeFieldInfoPtr_crate;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeFieldInfoPtr_cratePos;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeFieldInfoPtr_roads;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_GoIntro_Private_IEnumerator_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200030F RID: 783
		[ObfuscatedName("Intro+<GoIntro>d__14")]
		public sealed class _GoIntro_d__14 : global::Il2CppSystem.Object
		{
			// Token: 0x06004FB4 RID: 20404 RVA: 0x00123770 File Offset: 0x00121970
			// Note: this type is marked as 'beforefieldinit'.
			static _GoIntro_d__14()
			{
				Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Intro>.NativeClassPtr, "<GoIntro>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr);
				Intro._GoIntro_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, "<>1__state");
				Intro._GoIntro_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, "<>2__current");
				Intro._GoIntro_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, "<>4__this");
				Intro._GoIntro_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, 100665852);
				Intro._GoIntro_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, 100665853);
				Intro._GoIntro_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, 100665854);
				Intro._GoIntro_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, 100665855);
				Intro._GoIntro_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, 100665856);
				Intro._GoIntro_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr, 100665857);
			}

			// Token: 0x06004FB5 RID: 20405 RVA: 0x00123850 File Offset: 0x00121A50
			[CallerCount(0)]
			public unsafe _GoIntro_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Intro._GoIntro_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro._GoIntro_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004FB6 RID: 20406 RVA: 0x00123898 File Offset: 0x00121A98
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro._GoIntro_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004FB7 RID: 20407 RVA: 0x001238CC File Offset: 0x00121ACC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67646, XrefRangeEnd = 67655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro._GoIntro_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D0F RID: 7439
			// (get) Token: 0x06004FB8 RID: 20408 RVA: 0x00123908 File Offset: 0x00121B08
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro._GoIntro_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FB9 RID: 20409 RVA: 0x00123948 File Offset: 0x00121B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67655, XrefRangeEnd = 67660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro._GoIntro_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D10 RID: 7440
			// (get) Token: 0x06004FBA RID: 20410 RVA: 0x0012397C File Offset: 0x00121B7C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Intro._GoIntro_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004FBB RID: 20411 RVA: 0x0002E968 File Offset: 0x0002CB68
			public _GoIntro_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D0C RID: 7436
			// (get) Token: 0x06004FBC RID: 20412 RVA: 0x001239BC File Offset: 0x00121BBC
			// (set) Token: 0x06004FBD RID: 20413 RVA: 0x0002E971 File Offset: 0x0002CB71
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro._GoIntro_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro._GoIntro_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D0D RID: 7437
			// (get) Token: 0x06004FBE RID: 20414 RVA: 0x001239E4 File Offset: 0x00121BE4
			// (set) Token: 0x06004FBF RID: 20415 RVA: 0x0002E98C File Offset: 0x0002CB8C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro._GoIntro_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro._GoIntro_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D0E RID: 7438
			// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x00123A14 File Offset: 0x00121C14
			// (set) Token: 0x06004FC1 RID: 20417 RVA: 0x0002E9AB File Offset: 0x0002CBAB
			public unsafe Intro __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro._GoIntro_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Intro>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Intro._GoIntro_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003499 RID: 13465
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400349A RID: 13466
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400349B RID: 13467
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400349C RID: 13468
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400349D RID: 13469
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400349E RID: 13470
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400349F RID: 13471
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040034A0 RID: 13472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040034A1 RID: 13473
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
