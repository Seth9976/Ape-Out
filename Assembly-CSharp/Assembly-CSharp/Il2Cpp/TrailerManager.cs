using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Playables;

namespace Il2Cpp
{
	// Token: 0x020001C9 RID: 457
	public class TrailerManager : MonoBehaviour
	{
		// Token: 0x0600323F RID: 12863 RVA: 0x000BE480 File Offset: 0x000BC680
		// Note: this type is marked as 'beforefieldinit'.
		static TrailerManager()
		{
			Il2CppClassPointerStore<TrailerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "TrailerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr);
			TrailerManager.NativeFieldInfoPtr_devolverTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "devolverTitle");
			TrailerManager.NativeFieldInfoPtr_indieFundTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "indieFundTitle");
			TrailerManager.NativeFieldInfoPtr_lightsUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "lightsUp");
			TrailerManager.NativeFieldInfoPtr_tmpTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "tmpTitle");
			TrailerManager.NativeFieldInfoPtr_prevKills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "prevKills");
			TrailerManager.NativeFieldInfoPtr_lastKillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "lastKillTime");
			TrailerManager.NativeFieldInfoPtr_dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "dir");
			TrailerManager.NativeFieldInfoPtr_startflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "startflag");
			TrailerManager.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "anim");
			TrailerManager.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, 100667194);
			TrailerManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, 100667195);
			TrailerManager.NativeMethodInfoPtr_Trailer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, 100667196);
			TrailerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, 100667197);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000BE5B4 File Offset: 0x000BC7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85591, XrefRangeEnd = 85596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000BE5E8 File Offset: 0x000BC7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85596, XrefRangeEnd = 85626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000BE61C File Offset: 0x000BC81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85626, XrefRangeEnd = 85629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Trailer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager.NativeMethodInfoPtr_Trailer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000BE65C File Offset: 0x000BC85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrailerManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x000227BD File Offset: 0x000209BD
		public TrailerManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06003245 RID: 12869 RVA: 0x000BE698 File Offset: 0x000BC898
		// (set) Token: 0x06003246 RID: 12870 RVA: 0x000227C6 File Offset: 0x000209C6
		public unsafe Il2CppReferenceArray<GameObject> devolverTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_devolverTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_devolverTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06003247 RID: 12871 RVA: 0x000BE6C8 File Offset: 0x000BC8C8
		// (set) Token: 0x06003248 RID: 12872 RVA: 0x000227E5 File Offset: 0x000209E5
		public unsafe Il2CppReferenceArray<GameObject> indieFundTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_indieFundTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_indieFundTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x06003249 RID: 12873 RVA: 0x000BE6F8 File Offset: 0x000BC8F8
		// (set) Token: 0x0600324A RID: 12874 RVA: 0x00022804 File Offset: 0x00020A04
		public unsafe AudioSource lightsUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_lightsUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_lightsUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600324B RID: 12875 RVA: 0x000BE728 File Offset: 0x000BC928
		// (set) Token: 0x0600324C RID: 12876 RVA: 0x00022823 File Offset: 0x00020A23
		public unsafe Il2CppReferenceArray<GameObject> tmpTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_tmpTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_tmpTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x000BE758 File Offset: 0x000BC958
		// (set) Token: 0x0600324E RID: 12878 RVA: 0x00022842 File Offset: 0x00020A42
		public unsafe int prevKills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_prevKills);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_prevKills)) = value;
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x0600324F RID: 12879 RVA: 0x000BE780 File Offset: 0x000BC980
		// (set) Token: 0x06003250 RID: 12880 RVA: 0x0002285D File Offset: 0x00020A5D
		public unsafe float lastKillTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_lastKillTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_lastKillTime)) = value;
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x000BE7A8 File Offset: 0x000BC9A8
		// (set) Token: 0x06003252 RID: 12882 RVA: 0x00022878 File Offset: 0x00020A78
		public unsafe PlayableDirector dir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_dir);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableDirector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_dir), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06003253 RID: 12883 RVA: 0x000BE7D8 File Offset: 0x000BC9D8
		// (set) Token: 0x06003254 RID: 12884 RVA: 0x00022897 File Offset: 0x00020A97
		public unsafe bool startflag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_startflag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_startflag)) = value;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06003255 RID: 12885 RVA: 0x000BE800 File Offset: 0x000BCA00
		// (set) Token: 0x06003256 RID: 12886 RVA: 0x000228B2 File Offset: 0x00020AB2
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D6A RID: 7530
		private static readonly IntPtr NativeFieldInfoPtr_devolverTitle;

		// Token: 0x04001D6B RID: 7531
		private static readonly IntPtr NativeFieldInfoPtr_indieFundTitle;

		// Token: 0x04001D6C RID: 7532
		private static readonly IntPtr NativeFieldInfoPtr_lightsUp;

		// Token: 0x04001D6D RID: 7533
		private static readonly IntPtr NativeFieldInfoPtr_tmpTitle;

		// Token: 0x04001D6E RID: 7534
		private static readonly IntPtr NativeFieldInfoPtr_prevKills;

		// Token: 0x04001D6F RID: 7535
		private static readonly IntPtr NativeFieldInfoPtr_lastKillTime;

		// Token: 0x04001D70 RID: 7536
		private static readonly IntPtr NativeFieldInfoPtr_dir;

		// Token: 0x04001D71 RID: 7537
		private static readonly IntPtr NativeFieldInfoPtr_startflag;

		// Token: 0x04001D72 RID: 7538
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04001D73 RID: 7539
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04001D74 RID: 7540
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001D75 RID: 7541
		private static readonly IntPtr NativeMethodInfoPtr_Trailer_Private_IEnumerator_0;

		// Token: 0x04001D76 RID: 7542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000354 RID: 852
		[ObfuscatedName("TrailerManager+<Trailer>d__11")]
		public sealed class _Trailer_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x060053A0 RID: 21408 RVA: 0x0012F340 File Offset: 0x0012D540
			// Note: this type is marked as 'beforefieldinit'.
			static _Trailer_d__11()
			{
				Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrailerManager>.NativeClassPtr, "<Trailer>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr);
				TrailerManager._Trailer_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, "<>1__state");
				TrailerManager._Trailer_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, "<>2__current");
				TrailerManager._Trailer_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, "<>4__this");
				TrailerManager._Trailer_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, 100667198);
				TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, 100667199);
				TrailerManager._Trailer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, 100667200);
				TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, 100667201);
				TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, 100667202);
				TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr, 100667203);
			}

			// Token: 0x060053A1 RID: 21409 RVA: 0x0012F420 File Offset: 0x0012D620
			[CallerCount(0)]
			public unsafe _Trailer_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailerManager._Trailer_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager._Trailer_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053A2 RID: 21410 RVA: 0x0012F468 File Offset: 0x0012D668
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A3 RID: 21411 RVA: 0x0012F49C File Offset: 0x0012D69C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85575, XrefRangeEnd = 85586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager._Trailer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001E80 RID: 7808
			// (get) Token: 0x060053A4 RID: 21412 RVA: 0x0012F4D8 File Offset: 0x0012D6D8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053A5 RID: 21413 RVA: 0x0012F518 File Offset: 0x0012D718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85586, XrefRangeEnd = 85591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001E81 RID: 7809
			// (get) Token: 0x060053A6 RID: 21414 RVA: 0x0012F54C File Offset: 0x0012D74C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrailerManager._Trailer_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053A7 RID: 21415 RVA: 0x00030A58 File Offset: 0x0002EC58
			public _Trailer_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001E7D RID: 7805
			// (get) Token: 0x060053A8 RID: 21416 RVA: 0x0012F58C File Offset: 0x0012D78C
			// (set) Token: 0x060053A9 RID: 21417 RVA: 0x00030A61 File Offset: 0x0002EC61
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager._Trailer_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager._Trailer_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001E7E RID: 7806
			// (get) Token: 0x060053AA RID: 21418 RVA: 0x0012F5B4 File Offset: 0x0012D7B4
			// (set) Token: 0x060053AB RID: 21419 RVA: 0x00030A7C File Offset: 0x0002EC7C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager._Trailer_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager._Trailer_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001E7F RID: 7807
			// (get) Token: 0x060053AC RID: 21420 RVA: 0x0012F5E4 File Offset: 0x0012D7E4
			// (set) Token: 0x060053AD RID: 21421 RVA: 0x00030A9B File Offset: 0x0002EC9B
			public unsafe TrailerManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager._Trailer_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrailerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrailerManager._Trailer_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003741 RID: 14145
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003742 RID: 14146
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003743 RID: 14147
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003744 RID: 14148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003745 RID: 14149
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003746 RID: 14150
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003747 RID: 14151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003748 RID: 14152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003749 RID: 14153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
