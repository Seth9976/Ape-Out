using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations
{
	// Token: 0x02000027 RID: 39
	[StructLayout(2)]
	public struct AnimationStream
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x0000D504 File Offset: 0x0000B704
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationStream()
		{
			Il2CppClassPointerStore<AnimationStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr);
			AnimationStream.NativeFieldInfoPtr_m_AnimatorBindingsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "m_AnimatorBindingsVersion");
			AnimationStream.NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "constant");
			AnimationStream.NativeFieldInfoPtr_input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "input");
			AnimationStream.NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "output");
			AnimationStream.NativeFieldInfoPtr_workspace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "workspace");
			AnimationStream.NativeFieldInfoPtr_inputStreamAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "inputStreamAccessor");
			AnimationStream.NativeFieldInfoPtr_animationHandleBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, "animationHandleBinder");
			AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegate>("UnityEngine.Animations.AnimationStream::CopyAnimationStreamMotionInternal_Injected");
			AnimationStream.GetDeltaTime_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetDeltaTime_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetDeltaTime_Injected");
			AnimationStream.GetIsHumanStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetIsHumanStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetIsHumanStream_Injected");
			AnimationStream.GetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetVelocity_Injected");
			AnimationStream.SetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.SetVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::SetVelocity_Injected");
			AnimationStream.GetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetAngularVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetAngularVelocity_Injected");
			AnimationStream.SetAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.SetAngularVelocity_InjectedDelegate>("UnityEngine.Animations.AnimationStream::SetAngularVelocity_Injected");
			AnimationStream.GetRootMotionPosition_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetRootMotionPosition_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetRootMotionPosition_Injected");
			AnimationStream.GetRootMotionRotation_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetRootMotionRotation_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetRootMotionRotation_Injected");
			AnimationStream.GetInputStreamCount_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetInputStreamCount_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetInputStreamCount_Injected");
			AnimationStream.InternalGetInputStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalGetInputStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalGetInputStream_Injected");
			AnimationStream.InternalGetInputWeight_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalGetInputWeight_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalGetInputWeight_Injected");
			AnimationStream.GetHumanStream_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.GetHumanStream_InjectedDelegate>("UnityEngine.Animations.AnimationStream::GetHumanStream_Injected");
			AnimationStream.InternalReadSceneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalReadSceneTransforms_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalReadSceneTransforms_Injected");
			AnimationStream.InternalWriteSceneTransforms_InjectedDelegateField = IL2CPP.ResolveICall<AnimationStream.InternalWriteSceneTransforms_InjectedDelegate>("UnityEngine.Animations.AnimationStream::InternalWriteSceneTransforms_Injected");
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00004389 File Offset: 0x00002589
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationStream>.NativeClassPtr, ref this));
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000D6A4 File Offset: 0x0000B8A4
		public uint animatorBindingsVersion
		{
			get
			{
				return this.m_AnimatorBindingsVersion;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000D6BC File Offset: 0x0000B8BC
		public bool isValid
		{
			get
			{
				return this.m_AnimatorBindingsVersion >= 2U && this.constant != IntPtr.Zero && this.input != IntPtr.Zero && this.output != IntPtr.Zero && this.workspace != IntPtr.Zero && this.animationHandleBinder != IntPtr.Zero;
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000D734 File Offset: 0x0000B934
		public void CheckIsValid()
		{
			bool flag = !this.isValid;
			if (flag)
			{
				throw new InvalidOperationException("The AnimationStream is invalid.");
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000D75C File Offset: 0x0000B95C
		public float deltaTime
		{
			get
			{
				this.CheckIsValid();
				return this.GetDeltaTime();
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000D77C File Offset: 0x0000B97C
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0000439B File Offset: 0x0000259B
		public Vector3 velocity
		{
			get
			{
				this.CheckIsValid();
				return this.GetVelocity();
			}
			set
			{
				this.CheckIsValid();
				this.SetVelocity(value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000D79C File Offset: 0x0000B99C
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000043AD File Offset: 0x000025AD
		public Vector3 angularVelocity
		{
			get
			{
				this.CheckIsValid();
				return this.GetAngularVelocity();
			}
			set
			{
				this.CheckIsValid();
				this.SetAngularVelocity(value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		public Vector3 rootMotionPosition
		{
			get
			{
				this.CheckIsValid();
				return this.GetRootMotionPosition();
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		public Quaternion rootMotionRotation
		{
			get
			{
				this.CheckIsValid();
				return this.GetRootMotionRotation();
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000D7FC File Offset: 0x0000B9FC
		public bool isHumanStream
		{
			get
			{
				this.CheckIsValid();
				return this.GetIsHumanStream();
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000D81C File Offset: 0x0000BA1C
		public AnimationHumanStream AsHuman()
		{
			this.CheckIsValid();
			bool flag = !this.GetIsHumanStream();
			if (flag)
			{
				throw new InvalidOperationException("Cannot create an AnimationHumanStream for a generic rig.");
			}
			return this.GetHumanStream();
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000D854 File Offset: 0x0000BA54
		public int inputStreamCount
		{
			get
			{
				this.CheckIsValid();
				return this.GetInputStreamCount();
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000D874 File Offset: 0x0000BA74
		public AnimationStream GetInputStream(int index)
		{
			this.CheckIsValid();
			return this.InternalGetInputStream(index);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000D894 File Offset: 0x0000BA94
		public float GetInputWeight(int index)
		{
			this.CheckIsValid();
			return this.InternalGetInputWeight(index);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000043BF File Offset: 0x000025BF
		public void CopyAnimationStreamMotion(AnimationStream animationStream)
		{
			this.CheckIsValid();
			animationStream.CheckIsValid();
			this.CopyAnimationStreamMotionInternal(animationStream);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000043D9 File Offset: 0x000025D9
		public void ReadSceneTransforms()
		{
			this.CheckIsValid();
			this.InternalReadSceneTransforms();
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000043EA File Offset: 0x000025EA
		public void WriteSceneTransforms()
		{
			this.CheckIsValid();
			this.InternalWriteSceneTransforms();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000043FB File Offset: 0x000025FB
		public void CopyAnimationStreamMotionInternal(AnimationStream animationStream)
		{
			AnimationStream.CopyAnimationStreamMotionInternal_Injected(ref this, ref animationStream);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00004405 File Offset: 0x00002605
		public float GetDeltaTime()
		{
			return AnimationStream.GetDeltaTime_Injected(ref this);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000440D File Offset: 0x0000260D
		public bool GetIsHumanStream()
		{
			return AnimationStream.GetIsHumanStream_Injected(ref this);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		public Vector3 GetVelocity()
		{
			Vector3 vector;
			AnimationStream.GetVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00004415 File Offset: 0x00002615
		public void SetVelocity(Vector3 velocity)
		{
			AnimationStream.SetVelocity_Injected(ref this, ref velocity);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000D8CC File Offset: 0x0000BACC
		public Vector3 GetAngularVelocity()
		{
			Vector3 vector;
			AnimationStream.GetAngularVelocity_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000441F File Offset: 0x0000261F
		public void SetAngularVelocity(Vector3 velocity)
		{
			AnimationStream.SetAngularVelocity_Injected(ref this, ref velocity);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000D8E4 File Offset: 0x0000BAE4
		public Vector3 GetRootMotionPosition()
		{
			Vector3 vector;
			AnimationStream.GetRootMotionPosition_Injected(ref this, out vector);
			return vector;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000D8FC File Offset: 0x0000BAFC
		public Quaternion GetRootMotionRotation()
		{
			Quaternion quaternion;
			AnimationStream.GetRootMotionRotation_Injected(ref this, out quaternion);
			return quaternion;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00004429 File Offset: 0x00002629
		public int GetInputStreamCount()
		{
			return AnimationStream.GetInputStreamCount_Injected(ref this);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000D914 File Offset: 0x0000BB14
		public AnimationStream InternalGetInputStream(int index)
		{
			AnimationStream animationStream;
			AnimationStream.InternalGetInputStream_Injected(ref this, index, out animationStream);
			return animationStream;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00004431 File Offset: 0x00002631
		public float InternalGetInputWeight(int index)
		{
			return AnimationStream.InternalGetInputWeight_Injected(ref this, index);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000D92C File Offset: 0x0000BB2C
		public AnimationHumanStream GetHumanStream()
		{
			AnimationHumanStream animationHumanStream;
			AnimationStream.GetHumanStream_Injected(ref this, out animationHumanStream);
			return animationHumanStream;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000443A File Offset: 0x0000263A
		public void InternalReadSceneTransforms()
		{
			AnimationStream.InternalReadSceneTransforms_Injected(ref this);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00004442 File Offset: 0x00002642
		public void InternalWriteSceneTransforms()
		{
			AnimationStream.InternalWriteSceneTransforms_Injected(ref this);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000444A File Offset: 0x0000264A
		public static void CopyAnimationStreamMotionInternal_Injected(ref AnimationStream _unity_self, ref AnimationStream animationStream)
		{
			AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegateField(ref _unity_self, ref animationStream);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00004458 File Offset: 0x00002658
		public static float GetDeltaTime_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetDeltaTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00004465 File Offset: 0x00002665
		public static bool GetIsHumanStream_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetIsHumanStream_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00004472 File Offset: 0x00002672
		public static void GetVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00004480 File Offset: 0x00002680
		public static void SetVelocity_Injected(ref AnimationStream _unity_self, ref Vector3 velocity)
		{
			AnimationStream.SetVelocity_InjectedDelegateField(ref _unity_self, ref velocity);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000448E File Offset: 0x0000268E
		public static void GetAngularVelocity_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetAngularVelocity_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000449C File Offset: 0x0000269C
		public static void SetAngularVelocity_Injected(ref AnimationStream _unity_self, ref Vector3 velocity)
		{
			AnimationStream.SetAngularVelocity_InjectedDelegateField(ref _unity_self, ref velocity);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000044AA File Offset: 0x000026AA
		public static void GetRootMotionPosition_Injected(ref AnimationStream _unity_self, out Vector3 ret)
		{
			AnimationStream.GetRootMotionPosition_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000044B8 File Offset: 0x000026B8
		public static void GetRootMotionRotation_Injected(ref AnimationStream _unity_self, out Quaternion ret)
		{
			AnimationStream.GetRootMotionRotation_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000044C6 File Offset: 0x000026C6
		public static int GetInputStreamCount_Injected(ref AnimationStream _unity_self)
		{
			return AnimationStream.GetInputStreamCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000044D3 File Offset: 0x000026D3
		public static void InternalGetInputStream_Injected(ref AnimationStream _unity_self, int index, out AnimationStream ret)
		{
			AnimationStream.InternalGetInputStream_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000044E2 File Offset: 0x000026E2
		public static float InternalGetInputWeight_Injected(ref AnimationStream _unity_self, int index)
		{
			return AnimationStream.InternalGetInputWeight_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000044F0 File Offset: 0x000026F0
		public static void GetHumanStream_Injected(ref AnimationStream _unity_self, out AnimationHumanStream ret)
		{
			AnimationStream.GetHumanStream_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000044FE File Offset: 0x000026FE
		public static void InternalReadSceneTransforms_Injected(ref AnimationStream _unity_self)
		{
			AnimationStream.InternalReadSceneTransforms_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000450B File Offset: 0x0000270B
		public static void InternalWriteSceneTransforms_Injected(ref AnimationStream _unity_self)
		{
			AnimationStream.InternalWriteSceneTransforms_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_m_AnimatorBindingsVersion;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_constant;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_input;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_output;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_workspace;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_inputStreamAccessor;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_animationHandleBinder;

		// Token: 0x04000258 RID: 600
		[FieldOffset(0)]
		public uint m_AnimatorBindingsVersion;

		// Token: 0x04000259 RID: 601
		[FieldOffset(8)]
		public IntPtr constant;

		// Token: 0x0400025A RID: 602
		[FieldOffset(16)]
		public IntPtr input;

		// Token: 0x0400025B RID: 603
		[FieldOffset(24)]
		public IntPtr output;

		// Token: 0x0400025C RID: 604
		[FieldOffset(32)]
		public IntPtr workspace;

		// Token: 0x0400025D RID: 605
		[FieldOffset(40)]
		public IntPtr inputStreamAccessor;

		// Token: 0x0400025E RID: 606
		[FieldOffset(48)]
		public IntPtr animationHandleBinder;

		// Token: 0x0400025F RID: 607
		public const int InvalidIndex = -1;

		// Token: 0x04000260 RID: 608
		private static readonly AnimationStream.CopyAnimationStreamMotionInternal_InjectedDelegate CopyAnimationStreamMotionInternal_InjectedDelegateField;

		// Token: 0x04000261 RID: 609
		private static readonly AnimationStream.GetDeltaTime_InjectedDelegate GetDeltaTime_InjectedDelegateField;

		// Token: 0x04000262 RID: 610
		private static readonly AnimationStream.GetIsHumanStream_InjectedDelegate GetIsHumanStream_InjectedDelegateField;

		// Token: 0x04000263 RID: 611
		private static readonly AnimationStream.GetVelocity_InjectedDelegate GetVelocity_InjectedDelegateField;

		// Token: 0x04000264 RID: 612
		private static readonly AnimationStream.SetVelocity_InjectedDelegate SetVelocity_InjectedDelegateField;

		// Token: 0x04000265 RID: 613
		private static readonly AnimationStream.GetAngularVelocity_InjectedDelegate GetAngularVelocity_InjectedDelegateField;

		// Token: 0x04000266 RID: 614
		private static readonly AnimationStream.SetAngularVelocity_InjectedDelegate SetAngularVelocity_InjectedDelegateField;

		// Token: 0x04000267 RID: 615
		private static readonly AnimationStream.GetRootMotionPosition_InjectedDelegate GetRootMotionPosition_InjectedDelegateField;

		// Token: 0x04000268 RID: 616
		private static readonly AnimationStream.GetRootMotionRotation_InjectedDelegate GetRootMotionRotation_InjectedDelegateField;

		// Token: 0x04000269 RID: 617
		private static readonly AnimationStream.GetInputStreamCount_InjectedDelegate GetInputStreamCount_InjectedDelegateField;

		// Token: 0x0400026A RID: 618
		private static readonly AnimationStream.InternalGetInputStream_InjectedDelegate InternalGetInputStream_InjectedDelegateField;

		// Token: 0x0400026B RID: 619
		private static readonly AnimationStream.InternalGetInputWeight_InjectedDelegate InternalGetInputWeight_InjectedDelegateField;

		// Token: 0x0400026C RID: 620
		private static readonly AnimationStream.GetHumanStream_InjectedDelegate GetHumanStream_InjectedDelegateField;

		// Token: 0x0400026D RID: 621
		private static readonly AnimationStream.InternalReadSceneTransforms_InjectedDelegate InternalReadSceneTransforms_InjectedDelegateField;

		// Token: 0x0400026E RID: 622
		private static readonly AnimationStream.InternalWriteSceneTransforms_InjectedDelegate InternalWriteSceneTransforms_InjectedDelegateField;

		// Token: 0x02000198 RID: 408
		// (Invoke) Token: 0x06000826 RID: 2086
		private delegate void CopyAnimationStreamMotionInternal_InjectedDelegate(IntPtr _unity_self, IntPtr animationStream);

		// Token: 0x02000199 RID: 409
		// (Invoke) Token: 0x06000828 RID: 2088
		private delegate float GetDeltaTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200019A RID: 410
		// (Invoke) Token: 0x0600082A RID: 2090
		private delegate bool GetIsHumanStream_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x0200019B RID: 411
		// (Invoke) Token: 0x0600082C RID: 2092
		private delegate void GetVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200019C RID: 412
		// (Invoke) Token: 0x0600082E RID: 2094
		private delegate void SetVelocity_InjectedDelegate(IntPtr _unity_self, IntPtr velocity);

		// Token: 0x0200019D RID: 413
		// (Invoke) Token: 0x06000830 RID: 2096
		private delegate void GetAngularVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x0200019E RID: 414
		// (Invoke) Token: 0x06000832 RID: 2098
		private delegate void SetAngularVelocity_InjectedDelegate(IntPtr _unity_self, IntPtr velocity);

		// Token: 0x0200019F RID: 415
		// (Invoke) Token: 0x06000834 RID: 2100
		private delegate void GetRootMotionPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020001A0 RID: 416
		// (Invoke) Token: 0x06000836 RID: 2102
		private delegate void GetRootMotionRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020001A1 RID: 417
		// (Invoke) Token: 0x06000838 RID: 2104
		private delegate int GetInputStreamCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020001A2 RID: 418
		// (Invoke) Token: 0x0600083A RID: 2106
		private delegate void InternalGetInputStream_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x020001A3 RID: 419
		// (Invoke) Token: 0x0600083C RID: 2108
		private delegate float InternalGetInputWeight_InjectedDelegate(IntPtr _unity_self, int index);

		// Token: 0x020001A4 RID: 420
		// (Invoke) Token: 0x0600083E RID: 2110
		private delegate void GetHumanStream_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020001A5 RID: 421
		// (Invoke) Token: 0x06000840 RID: 2112
		private delegate void InternalReadSceneTransforms_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020001A6 RID: 422
		// (Invoke) Token: 0x06000842 RID: 2114
		private delegate void InternalWriteSceneTransforms_InjectedDelegate(IntPtr _unity_self);
	}
}
